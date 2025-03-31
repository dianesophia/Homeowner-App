using Microsoft.AspNetCore.Mvc;
using Hometown_Application.Data;
using Hometown_Application.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Hometown_Application.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;

namespace Hometown_Application.Controllers
{
    public class BillPaymentController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public BillPaymentController(ApplicationDBContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Pay()
        {
            var user = await _userManager.GetUserAsync(User); // Get currently logged-in user
            if (user == null)
            {
                return RedirectToAction("Login", "Account"); // Redirect if not logged in
            }

            ViewBag.UserId = user.Id; // Pass User ID to View
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PayBill(BillTransactionModel transaction)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            transaction.UserId = user.Id;

            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Invalid payment details.";
                return View("Pay", transaction);
            }

            var billAccount = _context.BillAccounts.FirstOrDefault(b => b.UserId == user.Id);
            if (billAccount == null)
            {
                TempData["Error"] = "User not found.";
                return View("Pay", transaction);
            }

            if (transaction.AmountPaid <= 0)
            {
                TempData["Error"] = "Payment amount must be greater than zero.";
                return View("Pay", transaction);
            }

            if (transaction.AmountPaid > billAccount.OutstandingBalance)
            {
                TempData["Error"] = "Payment exceeds outstanding balance.";
                return View("Pay", transaction);
            }

            // 🔹 Generate a Unique Payment Reference
            string paymentReference = $"PAY-{DateTime.UtcNow:yyyyMMddHHmmss}-{new Random().Next(1000, 9999)}";

            // Deduct payment from outstanding balance
            billAccount.OutstandingBalance -= transaction.AmountPaid;
            billAccount.UpdatedOn = DateTime.UtcNow;

            var newTransaction = new BillTransactionModel
            {
                UserId = user.Id,
                AmountPaid = transaction.AmountPaid,
                PaymentMethod = transaction.PaymentMethod,
                PaidBy = transaction.PaidBy,
                PaymentReference = paymentReference, // 🔹 Assign the generated reference
                PaymentDate = DateTime.UtcNow
            };

            _context.BillTransactions.Add(newTransaction);
            await _context.SaveChangesAsync();

            TempData["Success"] = $"Payment successful! Reference: {paymentReference}";
            return RedirectToAction("Index", "BillsTotal");
        }


        [HttpGet]
        public async Task<IActionResult> GetUserBalance()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return Json(new { error = "User not logged in" });
            }

            // 1️⃣ Get all bill items that the user should pay
            var totalBillAmount = await _context.BillItems
                .Where(b => b.IsDeleted == false) // Consider only active bills
                .SumAsync(b => b.Amount ?? 0); // Sum the bill amounts

            // 2️⃣ Get all payments the user has made
            var totalPaidAmount = await _context.BillTransactions
                .Where(t => t.UserId == user.Id && t.IsDeleted == false) // Consider only active payments
                .SumAsync(t => t.AmountPaid); // Sum payments

            // 3️⃣ Calculate outstanding balance
            var outstandingBalance = totalBillAmount - totalPaidAmount;

            return Json(new { user = user.UserName, balance = outstandingBalance });
        }

    }
}
