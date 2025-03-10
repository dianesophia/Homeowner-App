using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Hometown_Application.Data;
using Hometown_Application.Models;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace Hometown_Application.Controllers
{
    public class ServiceRequestController : Controller
    {
        private readonly ApplicationDBContext _context;

        public ServiceRequestController(ApplicationDBContext context)
        {
            _context = context;
        }

        // Display all service requests
        public IActionResult Index()
        {
            var requests = _context.ServiceRequests
                           .Where(r => r.IsDeleted == false || r.IsDeleted == null)
                           .ToList();
            return View(requests);
        }

        // Display form to create a new request
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.RequestTypes = _context.RequestTypes.ToList(); // Fetch request types
            return View();
        }
        /*  public IActionResult AdminView()
          {
              var serviceRequests = _context.ServiceRequests.ToList(); // Admin has access to all requests
              return View(serviceRequests);
          }*/

        public IActionResult AdminView()
        {
            var serviceRequests = _context.ServiceRequests
                .Where(r => r.IsDeleted == false || r.IsDeleted == null)
                .ToList();

            var staffProfiles = _context.StaffProfiles.ToList(); // Fetch all staff

            ViewBag.StaffProfiles = new SelectList(staffProfiles, "StaffId", "FullName");

            return View(serviceRequests);
        }

        public IActionResult HomeownerView()
    {
        var homeownerRequests = _context.ServiceRequests
            .Where(r => r.Email == User.Identity.Name) // Assuming you use the logged-in user's email to filter requests
            .ToList();
        return View(homeownerRequests);
    }

        // Handle form submission
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ServiceRequestModel model)
        {
            if (ModelState.IsValid)
            {
                _context.ServiceRequests.Add(model);
                _context.SaveChanges(); // Ensure this executes
                Console.WriteLine("Saved successfully!");
                return RedirectToAction("Index");
            }
            Console.WriteLine("Model is invalid!");
            return View(model);
        }


        // Display form to edit request
        /* [HttpGet]
         public IActionResult Edit(int id)
         {
             var request = _context.ServiceRequests.Find(id);
             if (request == null) return NotFound();
             return View(request);
         }*/

        public IActionResult Edit(int id)
        {
            var request = _context.ServiceRequests.Find(id);
            if (request == null) return NotFound();

            ViewBag.RequestTypes = _context.RequestTypes.ToList(); // Fetch request types
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
                _context.SaveChanges(); // Save changes
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // Display delete confirmation
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var request = _context.ServiceRequests.Find(id);
            if (request == null || request.IsDeleted == true)
            {
                return NotFound();
            }
            return View(request);
        }

        // Handle soft delete confirmation
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var request = _context.ServiceRequests.Find(id);
            if (request != null)
            {
                request.IsDeleted = true; // Mark as deleted
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult AssignStaff(int id)
        {
            var request = _context.ServiceRequests.Find(id);
            if (request == null) return NotFound();

            // Find staff members in the same department as the request category
            var staff = _context.StaffProfiles
                                .Where(s => s.Department.ToString() == request.Category)
                                .ToList();

            ViewBag.StaffList = new SelectList(staff, "StaffId", "FullName");
            return View(request);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AssignStaff(int id, int staffId)
        {
            var request = _context.ServiceRequests.Find(id);
            if (request == null) return NotFound();

            // Save the assignment in ServiceStaffAssignmentModel
            var assignment = new ServiceStaffAssignmentModel
            {
                ServiceRequestId = id,
                StaffId = staffId.ToString(),
                AssignedAt = DateTime.UtcNow,
                IsAccepted = false, // The staff still needs to accept the request
                IsUnavailable = false
            };

            _context.ServiceStaffAssignments.Add(assignment);

            // Update request status
            request.Status = "Assigned";
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        public IActionResult AutoAssignStaff(int requestId)
        {
            var request = _context.ServiceRequests.Find(requestId);
            if (request == null) return NotFound();

            // Find the first available staff in the same department
            var availableStaff = _context.StaffProfiles
                .Where(s => s.Department.ToString() == request.Category &&
                            !_context.ServiceStaffAssignments
                            .Any(a => a.StaffId == s.StaffId.ToString() && !a.IsUnavailable)) // Ensure staff is available
                .FirstOrDefault();

            if (availableStaff != null)
            {
                // Create a new staff assignment
                var assignment = new ServiceStaffAssignmentModel
                {
                    ServiceRequestId = requestId,
                    StaffId = availableStaff.StaffId.ToString(),
                    AssignedAt = DateTime.UtcNow,
                    IsAccepted = false, // The staff still needs to confirm
                    IsUnavailable = false
                };

                _context.ServiceStaffAssignments.Add(assignment);

                // Update request status
                request.Status = "Assigned";
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View("NoAvailableStaff"); // Redirect to a view showing no staff available
        }

    }
}
