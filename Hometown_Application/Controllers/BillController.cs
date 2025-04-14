using Microsoft.AspNetCore.Mvc;
using Hometown_Application.Models;
using Hometown_Application.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System;
using Hometown_Application.Data;
using Microsoft.EntityFrameworkCore;
using Hometown_Application.ViewModel;

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

            // Ensure model has BillId and UserId populated
            if (model.BillId == 0 || model.UserId == null)
            {
                return NotFound("Bill or User not found.");
            }

            model.IssuedDate = DateTime.UtcNow;
            model.IsPaid = false;
            model.AddedOn = DateTime.UtcNow;
            model.AddedBy = users.UserName;

            // Save the assignment to the database
            _context.BillAssignment.Add(model);
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
        public async Task<IActionResult> PayBill(int billId, decimal amountPaid,string paymentMethod, string referenceNumber)
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
                PaymentMethod = paymentMethod, // Replace with the actual method
                PaymentDate = DateTime.UtcNow,
                ReferenceNumber = referenceNumber,  
            };

            _context.Add(payment);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index)); 
        }


        public async Task<IActionResult> HomeownerBoard()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return NotFound("User not found");

            // Get the bills for the user
            var bills = await _context.Bills.Where(b => b.UserId == user.Id).ToListAsync();

            // Get BillAssignments for the logged-in user
            var billAssignments = await _context.BillAssignment
                .Where(ba => ba.UserId == user.Id)
                .Include(ba => ba.Bill)
                .ToListAsync();

            // Create the ViewModel
            var viewModel = bills.Select(b => new HomeownerBoardViewModel
            {
                BillId = b.BillId,
                RemainingBalance = b.RemainingBalance,
                Status = b.Status,
                //BillName = b.BillName,
                BillName = billAssignments.FirstOrDefault(ba => ba.BillId == b.BillId)?.BillName,
                Amount = billAssignments.FirstOrDefault(ba => ba.BillId == b.BillId)?.Amount ?? 0,
                Description = billAssignments.FirstOrDefault(ba => ba.BillId == b.BillId)?.Description,
                DueDate = billAssignments.FirstOrDefault(ba => ba.BillId == b.BillId)?.DueDate ?? DateTime.MinValue
            }).ToList();

            // Pass the ViewModel to the view
            return View(viewModel);
        }


        public async Task<IActionResult> CreateBill(List<BillItemsModel> billItems)
        {
            // Retrieve all homeowners
            var homeowners = await _userManager.GetUsersInRoleAsync("HomeOwner");

            if (homeowners == null || !homeowners.Any())
            {
                return NotFound("No homeowners found.");
            }

            // Calculate total amount for all the bill items
            decimal totalAmount = billItems.Sum(item => item.Amount ?? 0);

            // Create a bill for each homeowner
            foreach (var homeowner in homeowners)
            {
                var bill = new BillModel
                {
                    UserId = homeowner.Id,
                    DueDate = DateTime.UtcNow.AddDays(30), // For example, set a due date of 30 days from now
                    Status = "Pending",
                    TotalAmount = totalAmount,
                    RemainingBalance = totalAmount // Initially, the remaining balance is the same as the total amount
                };

                // Save the bill to the database
                _context.Bills.Add(bill);
                await _context.SaveChangesAsync();

                // Associate bill items with the newly created bill
            }

            // Redirect to Admin Board or a relevant page
            return RedirectToAction("AdminBoard");
        }

        public async Task<IActionResult> AssignAutomaticBills()
        {
            // Retrieve all users with the "HomeOwner" role
            var homeowners = await _userManager.GetUsersInRoleAsync("HomeOwner");

            if (homeowners == null || !homeowners.Any())
            {
                return NotFound("No homeowners found.");
            }
            var totalAmount = _context.BillItems
                             .Where(b => !b.IsDeleted)
                             .Sum(b => b.Amount) ?? 0;

            // Loop through each user and assign a bill automatically
            foreach (var homeowner in homeowners)
            {
                // Set the total amount and remaining balance (can be dynamic or constant)
                decimal remainingBalance = totalAmount; // Initially, Remaining Balance is equal to Total Amount

                // Create a new BillModel for each homeowner
                var newBill = new BillModel
                {
                    UserId = homeowner.Id,
                    IssueDate = DateTime.UtcNow,  // Current date as the issue date
                    DueDate = DateTime.UtcNow.AddDays(30),  // Due date set to 30 days from the current date
                    TotalAmount = totalAmount,
                    RemainingBalance = remainingBalance,
                    Status = "Pending",  // Default status
                    Remarks = "Automatic Bill Assignment"  // Optional remarks
                };

                // Add the new bill to the Bills table
                _context.Bills.Add(newBill);
            }

            // Save all the changes to the database
            await _context.SaveChangesAsync();

            // Optionally, redirect or display a success message
            return RedirectToAction("AdminBoard"); // Adjust to your specific admin dashboard page
        }

        public async Task<IActionResult> UserBillingHistory()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return NotFound("User not found");
            }

            // Get all payments related to the user's bills
            var payments = await _context.BillPayment
                                          .Include(p => p.Bill)
                                          .Where(p => p.Bill.UserId == user.Id) // Filter payments by the logged-in user's bills
                                          .ToListAsync();

            // Pass the payment records to the view
            return View(payments);
        }


        public async Task<IActionResult> PayBill(int billId)
        {
            // Fetch the bill details based on the bill ID
            var bill = await _context.Bills.FindAsync(billId);
            if (bill == null)
            {
                return NotFound();
            }

            // Pass the bill details to the view
            ViewBag.BillId = bill.BillId;
            ViewBag.RemainingBalance = bill.RemainingBalance;

            // Return the payment form view
            return View();
        }

        public async Task<IActionResult> ProcessPayment(int billId, decimal amountPaid, string paymentMethod, string referenceNumber)
        {


            var bill = await _context.Bills.FindAsync(billId);
            if (bill == null)
            {
                return NotFound();
            }

            // Update remaining balance
         //   bill.UpdateRemainingBalance(amountPaid);
           // _context.Update(bill);

            // Add payment record
            var payment = new BillPaymentModel
            {
                BillId = billId,
                AmountPaid = amountPaid,
                PaymentMethod = paymentMethod,
                PaymentDate = DateTime.UtcNow,
                ReferenceNumber = referenceNumber,
                IsApproved = false
            };

            _context.Add(payment);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(HomeownerBoard));
        }




        public async Task<IActionResult> PendingPayments()
        {
            var pendingPayments = await _context.BillPayment
                .Include(p => p.Bill)
                .Where(p => !p.IsApproved)
                .ToListAsync();

            return View(pendingPayments);
        }

        [HttpPost]
        public async Task<IActionResult> ApprovePayment(int paymentId)
        {
            var payment = await _context.BillPayment.FindAsync(paymentId);
            if (payment == null || payment.IsApproved)
            {
                return NotFound();
            }

            var bill = await _context.Bills.FindAsync(payment.BillId);
            if (bill == null)
            {
                return NotFound();
            }

            // Update
            bill.UpdateRemainingBalance(payment.AmountPaid);
            payment.IsApproved = true;

            _context.Update(bill);
            _context.Update(payment);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(PendingPayments));
        }


        public async Task<IActionResult> MarkAsPaid(int id)
        {
            var billAssignment = await _context.BillAssignment.FindAsync(id);
            if (billAssignment == null)
            {
                return NotFound();  
            }

            billAssignment.IsPaid = true;
            billAssignment.PaidDate = DateTime.UtcNow;
            _context.Update(billAssignment);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(HomeownerBoard));
        }


    }
}
