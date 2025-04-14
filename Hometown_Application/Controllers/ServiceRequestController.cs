using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Hometown_Application.Data;
using Hometown_Application.Models;
using Hometown_Application.ViewModels;

namespace Hometown_Application.Controllers
{
    [Authorize]
    public class ServiceRequestController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly ILogger<ServiceRequestController> _logger;

        public ServiceRequestController(ApplicationDBContext context, ILogger<ServiceRequestController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: Display all service requests (for all users or filtered by user)
        public async Task<IActionResult> Index(int page = 1, string sortBy = "AddedOn", bool ascending = false)
        {
            try
            {
                int pageSize = 10;
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                _logger.LogInformation($"Fetching requests for UserId: {userId}");

                if (string.IsNullOrEmpty(userId))
                {
                    _logger.LogWarning("UserId is null or empty. User might not be properly authenticated.");
                    TempData["Error"] = "Unable to fetch requests because user authentication failed.";
                    return View(new ServiceRequestListViewModel { Requests = new List<ServiceRequestModel>() });
                }

                var query = _context.ServiceRequests
                    .Include(r => r.Status)
                    .Include(r => r.RequestType)
                    .Include(r => r.Homeowner)
                    .Where(r => r.IsDeleted == false);

                // Filter by user if not an admin
                if (!User.IsInRole("Admin"))
                {
                    query = query.Where(r => r.UserId == userId);
                }

                // Sorting
                query = sortBy switch
                {
                    "Urgency" => ascending ? query.OrderBy(r => r.Urgency) : query.OrderByDescending(r => r.Urgency),
                    "Status" => ascending ? query.OrderBy(r => r.Status.StatusName) : query.OrderByDescending(r => r.Status.StatusName),
                    "RequestType" => ascending ? query.OrderBy(r => r.RequestType.Name) : query.OrderByDescending(r => r.RequestType.Name),
                    _ => ascending ? query.OrderBy(r => r.AddedOn) : query.OrderByDescending(r => r.AddedOn),
                };

                // Pagination
                var totalItems = await query.CountAsync();
                var requests = await query
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

                var viewModel = new ServiceRequestListViewModel
                {
                    Requests = requests,
                    CurrentPage = page,
                    TotalPages = (int)Math.Ceiling(totalItems / (double)pageSize),
                    SortBy = sortBy,
                    Ascending = ascending,
                    Statuses = await _context.Status
                        .OrderBy(s => s.StatusName)
                        .Select(s => new SelectListItem
                        {
                            Value = s.StatusId.ToString(),
                            Text = s.StatusName
                        })
                        .ToListAsync()
                };

                return View(viewModel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching service requests");
                TempData["Error"] = $"An error occurred while fetching service requests. Details: {ex.Message}";
                return View(new ServiceRequestListViewModel { Requests = new List<ServiceRequestModel>() });
            }
        }

        // GET: Display form to create a new request
        public async Task<IActionResult> Create()
        {
            var viewModel = new CreateServiceRequestViewModel
            {
                ServiceRequest = new ServiceRequestModel(),
                RequestTypes = await _context.RequestTypes
                    .Where(rt => rt.IsActive)
                    .OrderBy(rt => rt.Name)
                    .ToListAsync()
            };

            return View(viewModel);
        }

        // POST: Save a new request
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRequest(CreateServiceRequestViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.RequestTypes = await _context.RequestTypes
                    .Where(rt => rt.IsActive)
                    .OrderBy(rt => rt.Name)
                    .ToListAsync();
                return View("Create", viewModel);
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _logger.LogInformation($"Creating service request for UserId: {userId}");

            if (string.IsNullOrEmpty(userId))
            {
                _logger.LogWarning("UserId is null or empty during service request creation.");
                ModelState.AddModelError("", "Unable to create the request because user authentication failed.");
                viewModel.RequestTypes = await _context.RequestTypes
                    .Where(rt => rt.IsActive)
                    .OrderBy(rt => rt.Name)
                    .ToListAsync();
                return View("Create", viewModel);
            }

            // Find the "Pending" status in the database
            var pendingStatus = await _context.Status
                .FirstOrDefaultAsync(s => s.StatusName == "Pending");

            if (pendingStatus == null)
            {
                _logger.LogError("Pending status not found in the database.");
                ModelState.AddModelError("", "Unable to create the request because the default status is not configured.");
                viewModel.RequestTypes = await _context.RequestTypes
                    .Where(rt => rt.IsActive)
                    .OrderBy(rt => rt.Name)
                    .ToListAsync();
                return View("Create", viewModel);
            }

            var newRequest = new ServiceRequestModel
            {
                RequestTypeId = viewModel.ServiceRequest.RequestTypeId,
                StatusId = pendingStatus.StatusId, // Set default status to "Pending"
                Details = viewModel.ServiceRequest.Details,
                Location = viewModel.ServiceRequest.Location,
                Urgency = viewModel.ServiceRequest.Urgency,
                Email = viewModel.ServiceRequest.Email,
                Schedule = viewModel.ServiceRequest.Schedule,
                AddedOn = DateTime.UtcNow,
                AddedBy = User.Identity?.Name,
                UserId = userId,
                IsDeleted = false
            };

            try
            {
                _context.ServiceRequests.Add(newRequest);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Service request created successfully.";
                return RedirectToAction("RequestConfirmation");
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "Error saving service request");
                ModelState.AddModelError("", $"An error occurred while saving the request. Details: {ex.Message}");
                viewModel.RequestTypes = await _context.RequestTypes
                    .Where(rt => rt.IsActive)
                    .OrderBy(rt => rt.Name)
                    .ToListAsync();
                return View("Create", viewModel);
            }
        }

        // GET: Display user's submitted requests
        public async Task<IActionResult> RequestConfirmation()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized();
            }

            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                _logger.LogInformation($"Fetching requests for UserId: {userId}");

                if (string.IsNullOrEmpty(userId))
                {
                    _logger.LogWarning("UserId is null or empty. User might not be properly authenticated.");
                    TempData["Error"] = "Unable to fetch requests because user authentication failed.";
                    return View(new List<ServiceRequestModel>());
                }

                var userRequests = await _context.ServiceRequests
                    .Include(sr => sr.RequestType)
                    .Include(sr => sr.Status)
                    .Where(sr => sr.UserId == userId && sr.IsDeleted == false)
                    .OrderByDescending(sr => sr.AddedOn)
                    .ToListAsync();

                return View(userRequests);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching user service requests");
                TempData["Error"] = $"An error occurred while fetching your requests. Details: {ex.Message}";
                return View(new List<ServiceRequestModel>());
            }
        }

        // GET: Display all requests for Admin
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AdminView(int page = 1, string sortBy = "AddedOn", bool ascending = false)
        {
            try
            {
                int pageSize = 10;
                var query = _context.ServiceRequests
                    .Include(r => r.Status)
                    .Include(r => r.RequestType)
                    .Include(r => r.Homeowner)
                    .Where(r => r.IsDeleted == false);

                // Sorting
                query = sortBy switch
                {
                    "Urgency" => ascending ? query.OrderBy(r => r.Urgency) : query.OrderByDescending(r => r.Urgency),
                    "Status" => ascending ? query.OrderBy(r => r.Status.StatusName) : query.OrderByDescending(r => r.Status.StatusName),
                    "RequestType" => ascending ? query.OrderBy(r => r.RequestType.Name) : query.OrderByDescending(r => r.RequestType.Name),
                    _ => ascending ? query.OrderBy(r => r.AddedOn) : query.OrderByDescending(r => r.AddedOn),
                };

                // Pagination
                var totalItems = await query.CountAsync();
                var requests = await query
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

                var viewModel = new ServiceRequestListViewModel
                {
                    Requests = requests,
                    CurrentPage = page,
                    TotalPages = (int)Math.Ceiling(totalItems / (double)pageSize),
                    SortBy = sortBy,
                    Ascending = ascending,
                    Statuses = await _context.Status
                        .OrderBy(s => s.StatusName)
                        .Select(s => new SelectListItem
                        {
                            Value = s.StatusId.ToString(),
                            Text = s.StatusName
                        })
                        .ToListAsync()
                };

                return View(viewModel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching service requests for admin view");
                TempData["Error"] = "An error occurred while fetching service requests.";
                return View(new ServiceRequestListViewModel { Requests = new List<ServiceRequestModel>() });
            }
        }

        // GET: Display only the logged-in homeowner's requests
        public async Task<IActionResult> HomeownerView(int page = 1, string sortBy = "AddedOn", bool ascending = false)
        {
            try
            {
                int pageSize = 10;
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var query = _context.ServiceRequests
                    .Include(r => r.Status)
                    .Include(r => r.RequestType)
                    .Where(r => r.UserId == userId && r.IsDeleted == false);

                // Sorting
                query = sortBy switch
                {
                    "Urgency" => ascending ? query.OrderBy(r => r.Urgency) : query.OrderByDescending(r => r.Urgency),
                    "Status" => ascending ? query.OrderBy(r => r.Status.StatusName) : query.OrderByDescending(r => r.Status.StatusName),
                    "RequestType" => ascending ? query.OrderBy(r => r.RequestType.Name) : query.OrderByDescending(r => r.RequestType.Name),
                    _ => ascending ? query.OrderBy(r => r.AddedOn) : query.OrderByDescending(r => r.AddedOn),
                };

                // Pagination
                var totalItems = await query.CountAsync();
                var requests = await query
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

                var viewModel = new ServiceRequestListViewModel
                {
                    Requests = requests,
                    CurrentPage = page,
                    TotalPages = (int)Math.Ceiling(totalItems / (double)pageSize),
                    SortBy = sortBy,
                    Ascending = ascending,
                    Statuses = await _context.Status
                        .OrderBy(s => s.StatusName)
                        .Select(s => new SelectListItem
                        {
                            Value = s.StatusId.ToString(),
                            Text = s.StatusName
                        })
                        .ToListAsync()
                };

                return View(viewModel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching homeowner service requests");
                TempData["Error"] = "An error occurred while fetching your requests.";
                return View(new ServiceRequestListViewModel { Requests = new List<ServiceRequestModel>() });
            }
        }

        // Admin Action: Update Service Request Status
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> UpdateServiceRequestStatus(int id, int newStatusId)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid service request ID.");
            }

            var serviceRequest = await _context.ServiceRequests
                .FirstOrDefaultAsync(sr => sr.ServiceRequestId == id && !sr.IsDeleted);

            if (serviceRequest == null)
            {
                return NotFound("Service request not found.");
            }

            var status = await _context.Status
                .FirstOrDefaultAsync(s => s.StatusId == newStatusId);

            if (status == null)
            {
                return BadRequest("Invalid status value.");
            }

            try
            {
                serviceRequest.StatusId = newStatusId;
                serviceRequest.UpdatedOn = DateTime.UtcNow;
                serviceRequest.UpdatedBy = User.Identity?.Name;

                await _context.SaveChangesAsync();

                _logger.LogInformation("Service request {Id} status updated to {NewStatus}", id, status.StatusName);
                TempData["SuccessMessage"] = $"Service request status updated to {status.StatusName} successfully.";
                return RedirectToAction("AdminView");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating service request status for ID: {Id}", id);
                TempData["Error"] = $"An error occurred while updating the service request status: {ex.Message}";
                return RedirectToAction("AdminView");
            }
        }

        // GET: Edit Service Request Form
        public async Task<IActionResult> Edit(int id)
        {
            var serviceRequest = await _context.ServiceRequests
                .Include(sr => sr.RequestType)
                .Include(sr => sr.Status)
                .FirstOrDefaultAsync(sr => sr.ServiceRequestId == id && !sr.IsDeleted);

            if (serviceRequest == null)
            {
                return NotFound("Service request not found.");
            }

            // Ensure the user can only edit their own requests (unless they are an admin)
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!User.IsInRole("Admin") && serviceRequest.UserId != userId)
            {
                return Forbid();
            }

            var viewModel = new EditServiceRequestViewModel
            {
                ServiceRequest = serviceRequest,
                RequestTypes = await _context.RequestTypes
                    .Where(rt => rt.IsActive)
                    .OrderBy(rt => rt.Name)
                    .Select(rt => new SelectListItem
                    {
                        Value = rt.RequestTypeId.ToString(),
                        Text = rt.Name
                    })
                    .ToListAsync(),
                Statuses = await _context.Status
                    .OrderBy(s => s.StatusName)
                    .Select(s => new SelectListItem
                    {
                        Value = s.StatusId.ToString(),
                        Text = s.StatusName
                    })
                    .ToListAsync()
            };

            return View(viewModel);
        }

        // POST: Update Service Request
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(EditServiceRequestViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.RequestTypes = await _context.RequestTypes
                    .Where(rt => rt.IsActive)
                    .OrderBy(rt => rt.Name)
                    .Select(rt => new SelectListItem
                    {
                        Value = rt.RequestTypeId.ToString(),
                        Text = rt.Name
                    })
                    .ToListAsync();
                viewModel.Statuses = await _context.Status
                    .OrderBy(s => s.StatusName)
                    .Select(s => new SelectListItem
                    {
                        Value = s.StatusId.ToString(),
                        Text = s.StatusName
                    })
                    .ToListAsync();
                return View("Edit", viewModel);
            }

            var serviceRequest = await _context.ServiceRequests
                .FirstOrDefaultAsync(sr => sr.ServiceRequestId == viewModel.ServiceRequest.ServiceRequestId && !sr.IsDeleted);

            if (serviceRequest == null)
            {
                return NotFound("Service request not found.");
            }

            // Ensure the user can only edit their own requests (unless they are an admin)
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!User.IsInRole("Admin") && serviceRequest.UserId != userId)
            {
                return Forbid();
            }

            try
            {
                // Update the service request fields
                serviceRequest.RequestTypeId = viewModel.ServiceRequest.RequestTypeId;
                serviceRequest.Details = viewModel.ServiceRequest.Details;
                serviceRequest.Location = viewModel.ServiceRequest.Location;
                serviceRequest.Urgency = viewModel.ServiceRequest.Urgency;
                serviceRequest.Email = viewModel.ServiceRequest.Email;
                serviceRequest.Schedule = viewModel.ServiceRequest.Schedule;
                serviceRequest.UpdatedOn = DateTime.UtcNow;
                serviceRequest.UpdatedBy = User.Identity?.Name;

                // Only admins can update the status
                if (User.IsInRole("Admin"))
                {
                    serviceRequest.StatusId = viewModel.ServiceRequest.StatusId;
                }

                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Service request updated successfully.";
                return RedirectToAction("HomeownerView");
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "Error updating service request ID: {Id}", serviceRequest.ServiceRequestId);
                ModelState.AddModelError("", $"An error occurred while updating the request. Details: {ex.Message}");
                viewModel.RequestTypes = await _context.RequestTypes
                    .Where(rt => rt.IsActive)
                    .OrderBy(rt => rt.Name)
                    .Select(rt => new SelectListItem
                    {
                        Value = rt.RequestTypeId.ToString(),
                        Text = rt.Name
                    })
                    .ToListAsync();
                viewModel.Statuses = await _context.Status
                    .OrderBy(s => s.StatusName)
                    .Select(s => new SelectListItem
                    {
                        Value = s.StatusId.ToString(),
                        Text = s.StatusName
                    })
                    .ToListAsync();
                return View("Edit", viewModel);
            }
        }

        // POST: Delete (Soft Delete) Service Request
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var serviceRequest = await _context.ServiceRequests
                .FirstOrDefaultAsync(sr => sr.ServiceRequestId == id && !sr.IsDeleted);

            if (serviceRequest == null)
            {
                return NotFound("Service request not found.");
            }

            // Ensure the user can only delete their own requests (unless they are an admin)
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!User.IsInRole("Admin") && serviceRequest.UserId != userId)
            {
                return Forbid();
            }

            try
            {
                serviceRequest.IsDeleted = true;
                serviceRequest.UpdatedOn = DateTime.UtcNow;
                serviceRequest.UpdatedBy = User.Identity?.Name;

                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Service request deleted successfully.";
                return RedirectToAction("HomeownerView");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting service request ID: {Id}", id);
                TempData["Error"] = $"An error occurred while deleting the request. Details: {ex.Message}";
                return RedirectToAction("HomeownerView");
            }
        }
    }
}