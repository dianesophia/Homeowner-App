using Hometown_Application.Areas.Identity.Data;
using Hometown_Application.Data;
using Hometown_Application.Models;
using Hometown_Application.ViewModel;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Hometown_Application.Controllers
{
    // Custom anti-forgery token validation filter with logging
    public class CustomValidateAntiForgeryTokenAttribute : ActionFilterAttribute
    {
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            // Resolve the logger from the service provider
            var logger = context.HttpContext.RequestServices.GetRequiredService<ILogger<PollController>>();

            try
            {
                var antiForgeryService = context.HttpContext.RequestServices.GetRequiredService<IAntiforgery>();
                await antiForgeryService.ValidateRequestAsync(context.HttpContext);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Anti-forgery token validation failed.");
                context.Result = new StatusCodeResult(403);
                return;
            }

            await next();
        }
    }

    public class PollController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<PollController> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PollController(ApplicationDBContext context, UserManager<ApplicationUser> userManager, ILogger<PollController> logger, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        public IActionResult Test()
        {
            return Content("PollController is accessible!");
        }

        public async Task<IActionResult> Index()
        {
            var polls = await _context.Polls
                .Include(p => p.Creator)
                .OrderByDescending(p => p.CreatedDate)
                .ToListAsync();

            return View(polls);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(PollViewModel model)
        {
            try
            {
                _logger.LogInformation("Attempting to create a new poll. Received data: Title={Title}, Description={Description}, ExpiryDate={ExpiryDate}, IsActive={IsActive}, CreatorId={CreatorId}",
                    model.Title, model.Description, model.ExpiryDate, model.IsActive, model.CreatorId);

                if (model == null)
                {
                    _logger.LogWarning("Received null PollViewModel.");
                    model = new PollViewModel { IsActive = true };
                }

                if (ModelState.IsValid)
                {
                    var creatorId = model.CreatorId ?? User.FindFirstValue(ClaimTypes.NameIdentifier);
                    if (string.IsNullOrEmpty(creatorId))
                    {
                        _logger.LogError("CreatorId is null and no authenticated user found.");
                        throw new InvalidOperationException("CreatorId must be provided or user must be authenticated.");
                    }

                    var poll = new PollModel
                    {
                        Title = model.Title?.Trim(),
                        Description = model.Description?.Trim(),
                        ExpiryDate = model.ExpiryDate,
                        IsActive = model.IsActive,
                        CreatorId = creatorId,
                        CreatedDate = DateTime.UtcNow
                    };

                    _context.Add(poll);
                    await _context.SaveChangesAsync();
                    _logger.LogInformation("Poll created successfully. PollId: {PollId}", poll.PollId);

                    return RedirectToAction(nameof(Edit), new { id = poll.PollId });
                }
                else
                {
                    _logger.LogWarning("ModelState is invalid.");
                    var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                    foreach (var error in errors)
                    {
                        _logger.LogWarning("Validation Error: {ErrorMessage}", error);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating poll with Title: {Title}", model.Title ?? "null");
                ModelState.AddModelError("", "An error occurred while creating the poll. Please contact support.");
            }

            _logger.LogInformation("Returning Create view due to validation or error.");
            return View(model);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poll = await _context.Polls
                .Include(p => p.Questions)
                    .ThenInclude(q => q.Options)
                .FirstOrDefaultAsync(p => p.PollId == id);

            if (poll == null)
            {
                return NotFound();
            }

            var model = new PollViewModel
            {
                PollId = poll.PollId,
                Title = poll.Title,
                Description = poll.Description,
                ExpiryDate = poll.ExpiryDate,
                IsActive = poll.IsActive,
                CreatorId = poll.CreatorId,
                Questions = poll.Questions.Select(q => new QuestionViewModel
                {
                    QuestionId = q.QuestionId,
                    QuestionText = q.QuestionText,
                    QuestionType = q.QuestionType,
                    DisplayOrder = q.DisplayOrder,
                    IsRequired = q.IsRequired,
                    PollId = q.PollId,
                    Options = q.Options.Select(o => new OptionViewModel
                    {
                        OptionId = o.OptionId,
                        OptionText = o.OptionText,
                        DisplayOrder = o.DisplayOrder,
                        QuestionId = o.QuestionId
                    }).ToList()
                }).OrderBy(q => q.DisplayOrder).ToList()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, PollViewModel model)
        {
            if (id != model.PollId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var poll = await _context.Polls.FindAsync(id);
                    if (poll == null)
                    {
                        return NotFound();
                    }

                    poll.Title = model.Title;
                    poll.Description = model.Description;
                    poll.ExpiryDate = model.ExpiryDate;
                    poll.IsActive = model.IsActive;

                    _context.Update(poll);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PollExists(model.PollId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poll = await _context.Polls
                .Include(p => p.Creator)
                .Include(p => p.Questions)
                    .ThenInclude(q => q.Options)
                .FirstOrDefaultAsync(p => p.PollId == id);

            if (poll == null)
            {
                return NotFound();
            }

            return View(poll);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poll = await _context.Polls
                .Include(p => p.Creator)
                .FirstOrDefaultAsync(p => p.PollId == id);

            if (poll == null)
            {
                return NotFound();
            }

            return View(poll);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var poll = await _context.Polls.FindAsync(id);
            if (poll == null)
            {
                return NotFound();
            }

            _context.Polls.Remove(poll);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> TakePoll(int id)
        {
            _logger.LogInformation($"Loading poll with ID {id}");

            var poll = await _context.Polls
                .Include(p => p.Questions)
                .ThenInclude(q => q.Options)
                .FirstOrDefaultAsync(p => p.PollId == id);

            if (poll == null)
            {
                _logger.LogWarning($"Poll with ID {id} not found.");
                return NotFound("Poll not found.");
            }

            // Check if the poll is active and not expired
            if (!poll.IsActive)
            {
                _logger.LogWarning($"Poll with ID {id} is not active.");
                return BadRequest("This poll is no longer active.");
            }

            if (poll.ExpiryDate.HasValue && poll.ExpiryDate < DateTime.Now)
            {
                _logger.LogWarning($"Poll with ID {id} has expired. Expiry date: {poll.ExpiryDate}");
                return BadRequest("This poll has expired.");
            }

            // Check if the user has already responded (optional, based on requirements)
            if (User.Identity.IsAuthenticated)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var hasResponded = await _context.PollResponses
                    .AnyAsync(r => r.PollId == id && r.RespondentId == userId);
                if (hasResponded)
                {
                    _logger.LogWarning($"User {userId} has already responded to poll with ID {id}.");
                    return RedirectToAction("AlreadySubmitted", new { pollTitle = poll.Title });
                }
            }

            var model = new PollResponseViewModel
            {
                PollId = poll.PollId,
                PollTitle = poll.Title,
                PollDescription = poll.Description,
                Questions = poll.Questions
                    .OrderBy(q => q.DisplayOrder)
                    .Select(q => new QuestionResponseViewModel
                    {
                        QuestionId = q.QuestionId,
                        QuestionText = q.QuestionText,
                        QuestionType = q.QuestionType,
                        IsRequired = q.IsRequired,
                        DisplayOrder = q.DisplayOrder,
                        Options = q.Options
                            .OrderBy(o => o.DisplayOrder)
                            .Select(o => new OptionViewModel
                            {
                                OptionId = o.OptionId,
                                OptionText = o.OptionText,
                                DisplayOrder = o.DisplayOrder
                            }).ToList()
                    }).ToList()
            };

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [CustomValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitPoll(PollResponseViewModel model)
        {
            _logger.LogInformation($"Received SubmitPoll request for PollId {model.PollId}");

            try
            {
                // Log the received form data for debugging
                _logger.LogInformation("Received form data: PollId={PollId}, PollTitle={PollTitle}, QuestionsCount={QuestionsCount}",
                    model.PollId, model.PollTitle, model.Questions?.Count ?? 0);
                foreach (var question in model.Questions ?? new List<QuestionResponseViewModel>())
                {
                    _logger.LogInformation("Question: QuestionId={QuestionId}, SelectedOptionId={SelectedOptionId}",
                        question.QuestionId, question.SelectedOptionId);
                }

                // Fetch the poll to check its status and re-populate the model if needed
                var poll = await _context.Polls
                    .Include(p => p.Questions)
                    .ThenInclude(q => q.Options)
                    .FirstOrDefaultAsync(p => p.PollId == model.PollId);

                if (poll == null)
                {
                    _logger.LogWarning($"Poll with ID {model.PollId} not found.");
                    return NotFound("Poll not found.");
                }

                // Check if the poll is active and not expired
                if (!poll.IsActive)
                {
                    _logger.LogWarning($"Poll with ID {model.PollId} is not active.");
                    ModelState.AddModelError("", "This poll is no longer active.");
                }
                else if (poll.ExpiryDate.HasValue && poll.ExpiryDate < DateTime.Now)
                {
                    _logger.LogWarning($"Poll with ID {model.PollId} has expired. Expiry date: {poll.ExpiryDate}");
                    ModelState.AddModelError("", "This poll has expired.");
                }

                // Check for duplicate submission (optional, based on requirements)
                if (User.Identity.IsAuthenticated)
                {
                    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    var hasResponded = await _context.PollResponses
                        .AnyAsync(r => r.PollId == model.PollId && r.RespondentId == userId);
                    if (hasResponded)
                    {
                        _logger.LogWarning($"User {userId} has already responded to poll with ID {model.PollId}.");
                        return RedirectToAction("AlreadySubmitted", new { pollTitle = model.PollTitle });
                    }
                }

                // Validate that all required questions have a response
                foreach (var question in model.Questions ?? new List<QuestionResponseViewModel>())
                {
                    var pollQuestion = poll.Questions.FirstOrDefault(q => q.QuestionId == question.QuestionId);
                    if (pollQuestion == null)
                    {
                        _logger.LogWarning($"Invalid question ID: {question.QuestionId} for PollId {model.PollId}");
                        ModelState.AddModelError("", $"Invalid question ID: {question.QuestionId}");
                        continue;
                    }

                    if (pollQuestion.IsRequired && pollQuestion.QuestionType == QuestionType.MultipleChoice)
                    {
                        if (!question.SelectedOptionId.HasValue)
                        {
                            _logger.LogWarning($"Required multiple-choice question {question.QuestionId} has no selected option.");
                            ModelState.AddModelError($"Questions[{model.Questions.IndexOf(question)}].SelectedOptionId", "Please select an option for this required question.");
                        }
                    }
                }

                // Log all ModelState errors before checking ModelState.IsValid
                if (ModelState.Any(e => e.Value.Errors.Any()))
                {
                    _logger.LogWarning("ModelState contains errors:");
                    foreach (var state in ModelState)
                    {
                        foreach (var error in state.Value.Errors)
                        {
                            _logger.LogWarning($"Key: {state.Key}, Error: {error.ErrorMessage}");
                        }
                    }
                }
                else
                {
                    _logger.LogInformation("ModelState is valid, no errors found.");
                }

                if (!ModelState.IsValid)
                {
                    // Log validation errors (already logged above, but keeping this for consistency)
                    foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                    {
                        _logger.LogError($"Validation error: {error.ErrorMessage}");
                    }

                    // Re-populate the model, preserving user selections
                    model.PollTitle = poll.Title;
                    model.PollDescription = poll.Description;
                    var rePopulatedQuestions = poll.Questions
                        .OrderBy(q => q.DisplayOrder)
                        .Select(q => new QuestionResponseViewModel
                        {
                            QuestionId = q.QuestionId,
                            QuestionText = q.QuestionText,
                            QuestionType = q.QuestionType,
                            IsRequired = q.IsRequired,
                            DisplayOrder = q.DisplayOrder,
                            Options = q.Options
                                .OrderBy(o => o.DisplayOrder)
                                .Select(o => new OptionViewModel
                                {
                                    OptionId = o.OptionId,
                                    OptionText = o.OptionText,
                                    DisplayOrder = o.DisplayOrder
                                }).ToList()
                        }).ToList();

                    // Merge user selections into the re-populated questions
                    foreach (var rePopulatedQuestion in rePopulatedQuestions)
                    {
                        var userQuestion = model.Questions.FirstOrDefault(q => q.QuestionId == rePopulatedQuestion.QuestionId);
                        if (userQuestion != null)
                        {
                            rePopulatedQuestion.SelectedOptionId = userQuestion.SelectedOptionId;
                        }
                    }

                    model.Questions = rePopulatedQuestions;
                    _logger.LogInformation($"Returning to TakePoll view due to validation errors for PollId {model.PollId}");
                    return View("TakePoll", model);
                }

                // Process the responses
                try
                {
                    foreach (var question in model.Questions)
                    {
                        _logger.LogInformation($"Processing response for QuestionId: {question.QuestionId}, SelectedOptionId: {question.SelectedOptionId}");
                        var response = new PollResponseModel
                        {
                            PollId = model.PollId,
                            QuestionId = question.QuestionId,
                            SelectedOptionId = question.SelectedOptionId,
                            TextResponse = null, // Explicitly set to null since we only handle multiple-choice
                            RespondentId = User.Identity.IsAuthenticated ? User.FindFirstValue(ClaimTypes.NameIdentifier) : null,
                            IsAnonymous = !User.Identity.IsAuthenticated,
                            SubmissionDate = DateTime.Now
                        };
                        _context.PollResponses.Add(response);
                    }

                    await _context.SaveChangesAsync();
                    _logger.LogInformation($"Successfully saved responses for PollId {model.PollId}");
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, $"Error saving poll responses for PollId {model.PollId}");
                    ModelState.AddModelError("", "An error occurred while saving your responses. Please try again later.");

                    // Re-populate the model, preserving user selections
                    model.PollTitle = poll.Title;
                    model.PollDescription = poll.Description;
                    var rePopulatedQuestions = poll.Questions
                        .OrderBy(q => q.DisplayOrder)
                        .Select(q => new QuestionResponseViewModel
                        {
                            QuestionId = q.QuestionId,
                            QuestionText = q.QuestionText,
                            QuestionType = q.QuestionType,
                            IsRequired = q.IsRequired,
                            DisplayOrder = q.DisplayOrder,
                            Options = q.Options
                                .OrderBy(o => o.DisplayOrder)
                                .Select(o => new OptionViewModel
                                {
                                    OptionId = o.OptionId,
                                    OptionText = o.OptionText,
                                    DisplayOrder = o.DisplayOrder
                                }).ToList()
                        }).ToList();

                    foreach (var rePopulatedQuestion in rePopulatedQuestions)
                    {
                        var userQuestion = model.Questions.FirstOrDefault(q => q.QuestionId == rePopulatedQuestion.QuestionId);
                        if (userQuestion != null)
                        {
                            rePopulatedQuestion.SelectedOptionId = userQuestion.SelectedOptionId;
                        }
                    }

                    model.Questions = rePopulatedQuestions;
                    return View("TakePoll", model);
                }

                return RedirectToAction("ThankYou", new { pollTitle = model.PollTitle });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Unexpected error in SubmitPoll for PollId {model.PollId}");
                ModelState.AddModelError("", "An unexpected error occurred. Please try again later.");

                // Re-populate the model in case of an error
                var poll = await _context.Polls
                    .Include(p => p.Questions)
                    .ThenInclude(q => q.Options)
                    .FirstOrDefaultAsync(p => p.PollId == model.PollId);

                if (poll != null)
                {
                    model.PollTitle = poll.Title;
                    model.PollDescription = poll.Description;
                    var rePopulatedQuestions = poll.Questions
                        .OrderBy(q => q.DisplayOrder)
                        .Select(q => new QuestionResponseViewModel
                        {
                            QuestionId = q.QuestionId,
                            QuestionText = q.QuestionText,
                            QuestionType = q.QuestionType,
                            IsRequired = q.IsRequired,
                            DisplayOrder = q.DisplayOrder,
                            Options = q.Options
                                .OrderBy(o => o.DisplayOrder)
                                .Select(o => new OptionViewModel
                                {
                                    OptionId = o.OptionId,
                                    OptionText = o.OptionText,
                                    DisplayOrder = o.DisplayOrder
                                }).ToList()
                        }).ToList();

                    foreach (var rePopulatedQuestion in rePopulatedQuestions)
                    {
                        var userQuestion = model.Questions.FirstOrDefault(q => q.QuestionId == rePopulatedQuestion.QuestionId);
                        if (userQuestion != null)
                        {
                            rePopulatedQuestion.SelectedOptionId = userQuestion.SelectedOptionId;
                        }
                    }

                    model.Questions = rePopulatedQuestions;
                }

                return View("TakePoll", model);
            }
        }

        [AllowAnonymous]
        public IActionResult ThankYou(string pollTitle)
        {
            ViewData["PollTitle"] = pollTitle;
            return View();
        }

        [AllowAnonymous]
        public IActionResult AlreadySubmitted(string pollTitle)
        {
            ViewData["PollTitle"] = pollTitle;
            return View();
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Results(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poll = await _context.Polls
                .Include(p => p.Questions)
                    .ThenInclude(q => q.Options)
                .FirstOrDefaultAsync(p => p.PollId == id);

            if (poll == null)
            {
                return NotFound();
            }

            var responses = await _context.PollResponses
                .Where(r => r.PollId == id)
                .ToListAsync();

            var model = new PollResultsViewModel
            {
                PollId = poll.PollId,
                Title = poll.Title,
                Description = poll.Description,
                CreatedDate = poll.CreatedDate,
                ExpiryDate = poll.ExpiryDate,
                IsActive = poll.IsActive,
                TotalResponses = responses.Select(r => r.RespondentId).Distinct().Count(),
                Questions = poll.Questions.OrderBy(q => q.DisplayOrder).Select(q => new QuestionResultViewModel
                {
                    QuestionId = q.QuestionId,
                    QuestionText = q.QuestionText,
                    QuestionType = q.QuestionType,
                    ResponseCount = responses.Count(r => r.QuestionId == q.QuestionId)
                }).ToList()
            };

            foreach (var question in model.Questions)
            {
                if (question.QuestionType == Data.QuestionType.MultipleChoice)
                {
                    foreach (var option in poll.Questions
                        .FirstOrDefault(q => q.QuestionId == question.QuestionId)?.Options
                        .OrderBy(o => o.DisplayOrder).ToList() ?? new List<QuestionOptionModel>())
                    {
                        var count = responses.Count(r => r.SelectedOptionId == option.OptionId);
                        var percentage = question.ResponseCount > 0
                            ? (double)count / question.ResponseCount * 100
                            : 0;

                        question.Options.Add(new OptionResultViewModel
                        {
                            OptionId = option.OptionId,
                            OptionText = option.OptionText,
                            Count = count,
                            Percentage = Math.Round(percentage, 1)
                        });
                    }
                }
            }

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddQuestion(int pollId, string questionText, int questionType)
        {
            try
            {
                var poll = await _context.Polls.FindAsync(pollId);
                if (poll == null)
                {
                    return NotFound();
                }

                var maxDisplayOrder = await _context.PollQuestions
                    .Where(q => q.PollId == pollId)
                    .MaxAsync(q => (int?)q.DisplayOrder) ?? 0;

                var question = new PollQuestionModel
                {
                    PollId = pollId,
                    QuestionText = questionText,
                    QuestionType = (Data.QuestionType)questionType,
                    IsRequired = true,
                    DisplayOrder = maxDisplayOrder + 1
                };

                _context.PollQuestions.Add(question);
                await _context.SaveChangesAsync();
                _logger.LogInformation("Added question to poll {pollId}: {questionText}", pollId, questionText);

                return Json(new { success = true, questionId = question.QuestionId });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding question to poll {pollId}", pollId);
                return Json(new { success = false, message = "An error occurred while adding the question." });
            }
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddOption(int questionId, string optionText)
        {
            var question = await _context.PollQuestions.FindAsync(questionId);
            if (question == null)
            {
                return NotFound();
            }

            var maxDisplayOrder = await _context.QuestionOptions
                .Where(o => o.QuestionId == questionId)
                .MaxAsync(o => (int?)o.DisplayOrder) ?? 0;

            var option = new QuestionOptionModel
            {
                QuestionId = questionId,
                OptionText = optionText,
                DisplayOrder = maxDisplayOrder + 1
            };

            _context.QuestionOptions.Add(option);
            await _context.SaveChangesAsync();

            return Json(new { success = true, optionId = option.OptionId });
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteQuestion(int questionId)
        {
            var question = await _context.PollQuestions.FindAsync(questionId);
            if (question == null)
            {
                return NotFound();
            }

            _context.PollQuestions.Remove(question);
            await _context.SaveChangesAsync();

            return Json(new { success = true });
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteOption(int optionId)
        {
            var option = await _context.QuestionOptions.FindAsync(optionId);
            if (option == null)
            {
                return NotFound();
            }

            _context.QuestionOptions.Remove(option);
            await _context.SaveChangesAsync();

            return Json(new { success = true });
        }

        private bool PollExists(int id)
        {
            return _context.Polls.Any(e => e.PollId == id);
        }

        public IActionResult Participate(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(TakePoll), new { id });
        }

        [HttpGet]
        public IActionResult TestForm()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [CustomValidateAntiForgeryToken]
        public IActionResult TestFormSubmit(string testInput)
        {
            _logger.LogInformation($"Received TestFormSubmit with testInput: {testInput}");
            return Content("Form submitted successfully!");
        }
    }
}