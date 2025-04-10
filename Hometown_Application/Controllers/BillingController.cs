using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Hometown_Application.Data;
using Hometown_Application.Models;
using Hometown_Application.ViewModel;
using Hometown_Application.Areas.Identity.Data;

namespace Hometown_Application.Controllers
{
    public class BillingController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public BillingController(ApplicationDBContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Billing/Index
        public async Task<IActionResult> Index()
        {
            var bills = await _context.Bills
                .Include(b => b.ApplicationUser)
                .Include(b => b.BillDetails)
                .Include(b => b.Payments)
                .ToListAsync();
            return View(bills);
        }

        // GET: Billing/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var bill = await _context.Bills
                .Include(b => b.ApplicationUser)
                .Include(b => b.BillDetails)
                    .ThenInclude(d => d.BillItemType)
                .Include(b => b.Payments)
                .FirstOrDefaultAsync(m => m.BillId == id);

            if (bill == null)
                return NotFound();

            return View(bill);
        }

        // GET: Billing/Pay/5
        public async Task<IActionResult> Pay(int? id)
        {
            if (id == null)
                return NotFound();

            var bill = await _context.Bills
                .Include(b => b.Payments)
                .FirstOrDefaultAsync(m => m.BillId == id);

            if (bill == null)
                return NotFound();

            var totalPaid = bill.Payments.Sum(p => p.AmountPaid);
            var remainingBalance = bill.TotalAmount - totalPaid;

            var paymentViewModel = new PaymentViewModel
            {
                BillId = bill.BillId,
                RemainingBalance = remainingBalance
            };

            return View(paymentViewModel);
        }

        // POST: Billing/Pay
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Pay(PaymentViewModel model)
        {
            if (ModelState.IsValid)
            {
                var bill = await _context.Bills
                    .Include(b => b.Payments)
                    .FirstOrDefaultAsync(b => b.BillId == model.BillId);

                if (bill == null)
                    return NotFound();

                var totalPaid = bill.Payments.Sum(p => p.AmountPaid);
                var remainingBalance = bill.TotalAmount - totalPaid;

                if (model.AmountPaid > remainingBalance)
                {
                    ModelState.AddModelError(string.Empty, "Payment exceeds remaining balance.");
                    model.RemainingBalance = remainingBalance;
                    return View(model);
                }

                var payment = new BillPaymentModel
                {
                    BillId = model.BillId,
                    AmountPaid = model.AmountPaid,
                    PaymentMethod = model.PaymentMethod,
                    ReferenceNumber = model.ReferenceNumber,
                    PaymentDate = DateTime.UtcNow
                };

                _context.BillPayment.Add(payment);
                await _context.SaveChangesAsync();

                // Update bill status
                totalPaid += model.AmountPaid;
                bill.Status = totalPaid >= bill.TotalAmount ? "Paid" : "Pending";
                _context.Bills.Update(bill);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Details), new { id = model.BillId });
            }

            return View(model);
        }

        // GET: Billing/Create
        // BillingController.cs
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["UserId"] = _context.Users.ToList(); // Or a filtered list of homeowners
            return View();
        }

        // POST: Billing/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BillModel bill)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                bill.UserId = user.Id;
                bill.RemainingBalance = bill.TotalAmount;
                bill.IssueDate = DateTime.UtcNow;
                bill.Status = "Pending";

                _context.Bills.Add(bill);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // 👇 Add this to fix the error
            ViewData["UserId"] = _context.Users.ToList();
            return View(bill);
        }
    }

    
}
