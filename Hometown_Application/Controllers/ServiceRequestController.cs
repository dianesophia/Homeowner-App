using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using Hometown_Application.Data;
using Hometown_Application.Models;

namespace Hometown_Application.Controllers
{
    public class ServiceRequestController : Controller
    {
        private readonly ApplicationDBContext _context;

        public ServiceRequestController(ApplicationDBContext context)
        {
            _context = context;
        }

        // Display all service requests (Only non-deleted)
        public IActionResult Index()
        {
            var requests = _context.ServiceRequests
                .Include(r => r.Status) // Load related Status
                .Include(r => r.RequestType) // Load related RequestType
                .Include(r => r.Homeowner) // Load related Homeowner
              .Where(r => r.IsDeleted == false || r.IsDeleted == null)
                .ToList();

            return View(requests);
        }

        // Display form to create a new request
        public IActionResult Create(string searchQuery)
        {
            var requestTypes = _context.RequestTypes.Where(rt => rt.IsActive);

            if (!string.IsNullOrEmpty(searchQuery))
            {
                requestTypes = requestTypes.Where(rt => rt.Name.Contains(searchQuery));
            }

            ViewBag.RequestTypes = requestTypes.OrderBy(rt => rt.Name).ToList();
            ViewBag.Statuses = _context.Status.OrderBy(s => s.StatusName).ToList(); // Load status options
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ServiceRequestModel serviceRequest)
        {
            if (!ModelState.IsValid)
            {
                // Log errors to see why it's failing
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                Console.WriteLine("Validation Errors: " + string.Join(", ", errors));

                ViewBag.RequestTypes = _context.RequestTypes.Where(rt => rt.IsActive).OrderBy(rt => rt.Name).ToList();
                ViewBag.Statuses = _context.Status.OrderBy(s => s.StatusName).ToList();

                return View(serviceRequest);
            }

            try
            {
                string loggedInUser = User.Identity?.Name ?? "Anonymous";
                serviceRequest.AddedOn = DateTime.Now;
                serviceRequest.Email = loggedInUser;

                _context.ServiceRequests.Add(serviceRequest);
                _context.SaveChanges(); // Ensure this line executes
                return RedirectToAction("RequestConfirmation", new { id = serviceRequest.ServiceRequestId });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Saving Data: " + ex.Message);
                ModelState.AddModelError("", "An error occurred while saving the request.");
            }

            return View(serviceRequest);
        }



        [HttpGet]
        public IActionResult RequestConfirmation()
        {
            // Get the currently logged-in user
            string loggedInUser = User.Identity?.Name ?? "Anonymous";

            // Fetch all service requests made by this user
            var userRequests = _context.ServiceRequests
                .Include(sr => sr.RequestType) // Include related data if needed
                .Where(sr => sr.Email == loggedInUser) // Filter requests by user email
                .OrderByDescending(sr => sr.AddedOn) // Show newest requests first
                .ToList();

            return View(userRequests);
        }


       




        // Display all requests for Admin
        /*  public IActionResult AdminView()
          {
              var serviceRequests = _context.ServiceRequests
                  .Include(r => r.Status)
                  .Include(r => r.RequestType)
                  .Include(r => r.Homeowner)
                 .Where(r => r.IsDeleted == false || r.IsDeleted == null)
                  .ToList();

              var staffProfiles = _context.StaffProfiles.ToList();
              ViewBag.StaffProfiles = new SelectList(staffProfiles, "StaffId", "FullName");

              return View(serviceRequests);
          }
        */
        // Display only the logged-in homeowner's requests
        /* public IActionResult HomeownerView()
         {
             var homeownerRequests = _context.ServiceRequests
                 .Include(r => r.Status)
                 .Include(r => r.RequestType)
                 .Where(r => r.Homeowner.HomeownerId == User.Identity.Name) // Filter by logged-in user
                 .ToList();

             return View(homeownerRequests);
         }
        */
        // Display form to edit a request
        public IActionResult Edit(int id)
        {
            var request = _context.ServiceRequests.Find(id);
            if (request == null) return NotFound();

            ViewBag.RequestTypes = _context.RequestTypes.ToList();
            ViewBag.Statuses = _context.Status.ToList();
            return View(request);
        }

        // Handle edit request
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ServiceRequestModel model)
        {
            if (ModelState.IsValid)
            {
                _context.ServiceRequests.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // Display delete confirmation
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var request = _context.ServiceRequests.Find(id);
            if (request == null || request.IsDeleted == true) return NotFound();
            return View(request);
        }


        // Handle soft delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var request = _context.ServiceRequests.Find(id);
            if (request != null)
            {
                request.IsDeleted = true;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        /*// Display staff assignment form
        [HttpGet]
        public IActionResult AssignStaff(int id)
        {
            var request = _context.ServiceRequests.Include(r => r.RequestType).FirstOrDefault(r => r.Id == id);
            if (request == null) return NotFound();

            var staff = _context.StaffProfiles
                .Where(s => s.DepartmentId == request.RequestTypeId) // Match request type with department
                .ToList();

            ViewBag.StaffList = new SelectList(staff, "StaffId", "FullName");
            return View(request);
        }

        // Handle staff assignment
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AssignStaff(int id, int staffId)
        {
            var request = _context.ServiceRequests.Find(id);
            if (request == null) return NotFound();

            var assignment = new ServiceStaffAssignmentModel
            {
                ServiceRequestId = id,
                StaffId = staffId,
                AssignedAt = DateTime.UtcNow,
                IsAccepted = false,
                IsUnavailable = false
            };

            _context.ServiceStaffAssignments.Add(assignment);

            // Update request status
            request.StatusId = _context.Status.FirstOrDefault(s => s.Name == "Assigned")?.Id ?? request.StatusId;
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // Automatically assign available staff
        public IActionResult AutoAssignStaff(int requestId)
        {
            var request = _context.ServiceRequests.Include(r => r.RequestType).FirstOrDefault(r => r.Id == requestId);
            if (request == null) return NotFound();

            var availableStaff = _context.StaffProfiles
                .Where(s => s.DepartmentId == request.RequestTypeId &&
                            !_context.ServiceStaffAssignments
                            .Any(a => a.StaffId == s.StaffId && !a.IsUnavailable))
                .FirstOrDefault();

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

                _context.ServiceStaffAssignments.Add(assignment);

                // Update request status
                request.StatusId = _context.Status.FirstOrDefault(s => s.Name == "Assigned")?.Id ?? request.StatusId;
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View("NoAvailableStaff");
        }*/
    }
}
