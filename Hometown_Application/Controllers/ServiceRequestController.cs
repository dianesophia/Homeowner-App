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

        // GET: Display all service requests with pagination and sorting
        public async Task<IActionResult> Index(int page = 1, string sortBy = "AddedOn", bool ascending = false)
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
                    Ascending = ascending
                };

                return View(viewModel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching service requests");
                TempData["Error"] = "An error occurred while fetching service requests.";
                return View(new ServiceRequestListViewModel { Requests = new List<ServiceRequestModel>() });
            }
        }

        // GET: Display form to create a new request
        public async Task<IActionResult> Create(string searchQuery)
        {
            var requestTypesQuery = _context.RequestTypes.Where(rt => rt.IsActive);

            if (!string.IsNullOrEmpty(searchQuery))
            {
                requestTypesQuery = requestTypesQuery.Where(rt => rt.Name.Contains(searchQuery));
            }

            var viewModel = new CreateServiceRequestViewModel
            {
                ServiceRequest = new ServiceRequestModel(),
                RequestTypes = await requestTypesQuery.OrderBy(rt => rt.Name).ToListAsync(),
                Statuses = await _context.Status
                    .OrderBy(s => s.StatusName)
                    .Select(s => new SelectListItem { Value = s.StatusId.ToString(), Text = s.StatusName })
                    .ToListAsync(),
                SearchQuery = searchQuery

            };

            return View(viewModel);
        }

        // POST: Save a new request
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRequest(ServiceRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CreateServiceRequestViewModel
                {
                    ServiceRequest = model,
                    RequestTypes = await _context.RequestTypes
                        .Where(rt => rt.IsActive)
                        .OrderBy(rt => rt.Name)
                        .ToListAsync(),
                    Statuses = await _context.Status
                        .OrderBy(s => s.StatusName)
                        .Select(s => new SelectListItem { Value = s.StatusId.ToString(), Text = s.StatusName })
                        .ToListAsync()
                };
                return View("Create", viewModel);
            }

            var newRequest = new ServiceRequestModel
            {
                RequestTypeId = model.RequestTypeId,
                StatusId = model.StatusId,
                Details = model.Details,
                Location = model.Location,
                Urgency = model.Urgency,
                Email = model.Email,
                Schedule = model.Schedule,
                AddedOn = DateTime.UtcNow,
                AddedBy = User.Identity?.Name,
                UserId = User.FindFirstValue(ClaimTypes.NameIdentifier),
                IsDeleted = false
            };

            try
            {
                _context.ServiceRequests.Add(newRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "Error saving service request");
                ModelState.AddModelError("", "An error occurred while saving the request.");
                var viewModel = new CreateServiceRequestViewModel
                {
                    ServiceRequest = model,
                    RequestTypes = await _context.RequestTypes
                        .Where(rt => rt.IsActive)
                        .OrderBy(rt => rt.Name)
                        .ToListAsync(),
                    Statuses = await _context.Status
                        .OrderBy(s => s.StatusName)
                        .Select(s => new SelectListItem { Value = s.StatusId.ToString(), Text = s.StatusName })
                        .ToListAsync()
                };
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
                var userRequests = await _context.ServiceRequests
                    .Include(sr => sr.RequestType)
                    .Include(sr => sr.Status)
                    .Where(sr => sr.UserId == userId)
                    .OrderByDescending(sr => sr.AddedOn)
                    .ToListAsync();

                return View(userRequests);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching user service requests");
                TempData["Error"] = "An error occurred while fetching your requests.";
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
                    Ascending = ascending
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
                    Ascending = ascending
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

        // GET: Display form to edit a request
        public async Task<IActionResult> Edit(int id)
        {
            var request = await _context.ServiceRequests
                .Include(r => r.RequestType)
                .Include(r => r.Status)
                .FirstOrDefaultAsync(r => r.ServiceRequestId == id);

            if (request == null || request.IsDeleted)
            {
                return NotFound();
            }

            // Check ownership
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (request.UserId != userId && !User.IsInRole("Admin"))
            {
                return Forbid();
            }

            var viewModel = new EditServiceRequestViewModel
            {
                ServiceRequest = request,
                RequestTypes = await _context.RequestTypes
                    .Select(rt => new SelectListItem { Value = rt.RequestTypeId.ToString(), Text = rt.Name })
                    .ToListAsync(),
                Statuses = await _context.Status
                    .Select(s => new SelectListItem { Value = s.StatusId.ToString(), Text = s.StatusName })
                    .ToListAsync()
            };

            return View(viewModel);
        }

        // POST: Handle edit request
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditServiceRequestViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.RequestTypes = await _context.RequestTypes
                    .Select(rt => new SelectListItem { Value = rt.RequestTypeId.ToString(), Text = rt.Name })
                    .ToListAsync();
                viewModel.Statuses = await _context.Status
                    .Select(s => new SelectListItem { Value = s.StatusId.ToString(), Text = s.StatusName })
                    .ToListAsync();
                return View(viewModel);
            }

            var request = await _context.ServiceRequests.FindAsync(viewModel.ServiceRequest.ServiceRequestId);
            if (request == null || request.IsDeleted)
            {
                return NotFound();
            }

            // Check ownership
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (request.UserId != userId && !User.IsInRole("Admin"))
            {
                return Forbid();
            }

            // Update fields
            request.RequestTypeId = viewModel.ServiceRequest.RequestTypeId;
            request.StatusId = viewModel.ServiceRequest.StatusId;
            request.Details = viewModel.ServiceRequest.Details;
            request.Location = viewModel.ServiceRequest.Location;
            request.Urgency = viewModel.ServiceRequest.Urgency;
            request.Email = viewModel.ServiceRequest.Email;
            request.Schedule = viewModel.ServiceRequest.Schedule;
            request.UpdatedOn = DateTime.UtcNow;
            request.UpdatedBy = User.Identity?.Name;

            try
            {
                _context.ServiceRequests.Update(request);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "Error updating service request");
                ModelState.AddModelError("", "An error occurred while updating the request.");
                viewModel.RequestTypes = await _context.RequestTypes
                    .Select(rt => new SelectListItem { Value = rt.RequestTypeId.ToString(), Text = rt.Name })
                    .ToListAsync();
                viewModel.Statuses = await _context.Status
                    .Select(s => new SelectListItem { Value = s.StatusId.ToString(), Text = s.StatusName })
                    .ToListAsync();
                return View(viewModel);
            }
        }

        // GET: Display delete confirmation
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var request = await _context.ServiceRequests
                .Include(r => r.RequestType)
                .FirstOrDefaultAsync(r => r.ServiceRequestId == id);

            if (request == null || request.IsDeleted)
            {
                return NotFound();
            }

            // Check ownership
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (request.UserId != userId && !User.IsInRole("Admin"))
            {
                return Forbid();
            }

            return View(request);
        }

        // POST: Handle soft delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var request = await _context.ServiceRequests.FindAsync(id);
            if (request == null || request.IsDeleted)
            {
                return NotFound();
            }

            // Check ownership
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (request.UserId != userId && !User.IsInRole("Admin"))
            {
                return Forbid();
            }

            try
            {
                request.IsDeleted = true;
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "Error deleting service request");
                TempData["Error"] = "An error occurred while deleting the request.";
                return RedirectToAction("Index");
            }
        }

        /* Commented out staff assignment functionality
        // GET: Display staff assignment form
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> AssignStaff(int id)
        {
            var request = await _context.ServiceRequests
                .Include(r => r.RequestType)
                .FirstOrDefaultAsync(r => r.ServiceRequestId == id);

            if (request == null || request.IsDeleted)
            {
                return NotFound();
            }

            var staff = await _context.StaffProfiles
                .Where(s => s.DepartmentId == request.RequestTypeId)
                .Select(s => new SelectListItem { Value = s.StaffId.ToString(), Text = s.FullName })
                .ToListAsync();

            ViewBag.StaffList = staff;
            return View(request);
        }

        // POST: Handle staff assignment
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AssignStaff(int id, int staffId)
        {
            var request = await _context.ServiceRequests.FindAsync(id);
            if (request == null || request.IsDeleted)
            {
                return NotFound();
            }

            var assignment = new ServiceStaffAssignmentModel
            {
                ServiceRequestId = id,
                StaffId = staffId,
                AssignedAt = DateTime.UtcNow,
                IsAccepted = false,
                IsUnavailable = false
            };

            try
            {
                _context.ServiceStaffAssignments.Add(assignment);

                // Update request status to "Assigned"
                var assignedStatus = await _context.Status
                    .FirstOrDefaultAsync(s => s.StatusName == "Assigned");
                if (assignedStatus != null)
                {
                    request.StatusId = assignedStatus.StatusId;
                }

                await _context.SaveChangesAsync();
                return RedirectToAction("AdminView");
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "Error assigning staff to service request");
                TempData["Error"] = "An error occurred while assigning staff.";
                return RedirectToAction("AdminView");
            }
        }

        // POST: Automatically assign available staff
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AutoAssignStaff(int requestId)
        {
            var request = await _context.ServiceRequests
                .Include(r => r.RequestType)
                .FirstOrDefaultAsync(r => r.ServiceRequestId == requestId);

            if (request == null || request.IsDeleted)
            {
                return NotFound();
            }

            var availableStaff = await _context.StaffProfiles
                .Where(s => s.DepartmentId == request.RequestTypeId &&
                            !_context.ServiceStaffAssignments
                                .Any(a => a.StaffId == s.StaffId && !a.IsUnavailable))
                .FirstOrDefaultAsync();

            if (availableStaff != null)
            {
                var assignment = new ServiceStaffAssignmentModel
                {
                    ServiceRequestId = requestId,
                    StaffId = availableStaff.StaffId,
                    AssignedAt = DateTime.UtcNow,
                    IsAccepted = false,
                    IsUnavailable = false
                };

                try
                {
                    _context.ServiceStaffAssignments.Add(assignment);

                    // Update request status to "Assigned"
                    var assignedStatus = await _context.Status
                        .FirstOrDefaultAsync(s => s.StatusName == "Assigned");
                    if (assignedStatus != null)
                    {
                        request.StatusId = assignedStatus.StatusId;
                    }

                    await _context.SaveChangesAsync();
                    return RedirectToAction("AdminView");
                }
                catch (DbUpdateException ex)
                {
                    _logger.LogError(ex, "Error auto-assigning staff to service request");
                    TempData["Error"] = "An error occurred while auto-assigning staff.";
                    return RedirectToAction("AdminView");
                }
            }

            return View("NoAvailableStaff");
        }
        */
    }
}