using Microsoft.AspNetCore.Mvc;
using Hometown_Application.Models;
using Hometown_Application.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System;
using Hometown_Application.Data;
using Microsoft.EntityFrameworkCore;

namespace Hometown_Application.Controllers
{
    public class BillController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public BillController(ApplicationDBContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> AdminBoard()
        {
            // Step 1: Get the total amount of each PaymentDuration
            var totalMonthlyBills = await _context.BillItems
                .Where(bi => !bi.IsDeleted && bi.PaymentDuration == "Monthly")
                .SumAsync(bi => bi.Amount ?? 0);

            var totalYearlyBills = await _context.BillItems
                .Where(bi => !bi.IsDeleted && bi.PaymentDuration == "Yearly")
                .SumAsync(bi => bi.Amount ?? 0);

            var totalQuarterlyBills = await _context.BillItems
                .Where(bi => !bi.IsDeleted && bi.PaymentDuration == "Quarterly")
                .SumAsync(bi => bi.Amount ?? 0);

            // Step 2: Get total number of homeowners
            var totalHomeowners = await _userManager.GetUsersInRoleAsync("HomeOwner");

           

            // Step 4: Pass all the results to the view
            ViewBag.TotalMonthlyBills = totalMonthlyBills * totalHomeowners.Count;
            ViewBag.TotalYearlyBills = totalYearlyBills * totalHomeowners.Count;
            ViewBag.TotalQuarterlyBills = totalQuarterlyBills * totalHomeowners.Count;

            var bills = await _context.Bills.Include(b => b.ApplicationUser).ToListAsync();

            ViewBag.BillList = bills;
         

            return View();
        }

        public async Task<IActionResult> AssignUserBill()
        {
            // Get all users with the "HomeOwner" role
            var homeowners = await _userManager.GetUsersInRoleAsync("HomeOwner");

            // Pass the list of users to the view
            var model = new BillAssignmentModel
            {
                Users = homeowners
            };

            return View(model);
        }


        public async Task<IActionResult> AssignUser(BillAssignmentModel model)
        {
            var users = await _userManager.GetUserAsync(User);
            if (users == null) return RedirectToAction("Index");

          /*  var bill = await _context.Bills.FindAsync(model.BillId);
            if (bill == null)
            {
                return NotFound("Bill not found");
            }*/

            model.IssuedDate = DateTime.UtcNow;
            model.IsPaid = false;
            model.AddedOn = DateTime.UtcNow;
            model.AddedBy = users.UserName;
            _context.BillAssignment.Add(model);
            await _context.SaveChangesAsync();


            // Update the remaining balance of the bill
            /*bill.RemainingBalance += model.Amount; // Add assigned amount to remaining balance
            _context.Update(bill);*/
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(BillAssignmentList));
        }





        public IActionResult BillAssignmentList()
        {
            // Fetching all BillAssignmentModel records from the database
            var billAssignments = _context.BillAssignment
                                          .Include(b => b.ApplicationUser)
                                         // .Include(b => b.Bill)
                                          .Include(b => b.Users) // Include users associated with the bill
                                          .ToList();  // Fetch all BillAssignmentModel records as a list

            // Passing the list of BillAssignmentModel to the view
            return View(billAssignments);
        }


        [HttpPost]
        public async Task<IActionResult> PayBill(int billId, decimal amountPaid)
        {
            var bill = await _context.Bills.FindAsync(billId);
            if (bill == null)
            {
                return NotFound();
            }

            // Update remaining balance
            bill.UpdateRemainingBalance(amountPaid);
            _context.Update(bill);

            // Add payment record
            var payment = new BillPaymentModel
            {
                BillId = billId,
                AmountPaid = amountPaid,
                PaymentMethod = "Cash", // Replace with the actual method
                PaymentDate = DateTime.UtcNow
            };

            _context.Add(payment);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index)); 
        }


        public async Task<IActionResult> HomeownerBoard()
        {
            // Get the current user (homeowner)
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Index", "Home"); // Redirect to home if user is not found
            }

            // Fetch unpaid bills and only select the RemainingBalance
            var homeownerBills = await _context.Bills
                .Where(b => b.UserId == user.Id && !b.IsPaid) // Only unpaid bills
                .ToListAsync();

            // Check if there are no bills
            if (homeownerBills == null || !homeownerBills.Any())
            {
                return View(new List<BillModel>());
            }

            // Pass the bills to the view
            return View(homeownerBills);
        }

    }
}
