using Hometown_Application.Data;
using Hometown_Application.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hometown_Application.Areas.Identity.Data;

namespace Hometown_Application.Controllers
{
    [Authorize]
    public class BillingController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly StripeSettings _stripeSettings;

        public BillingController(ApplicationDBContext context, UserManager<ApplicationUser> userManager, IOptions<StripeSettings> stripeSettings)
        {
            _context = context;
            _userManager = userManager;
            _stripeSettings = stripeSettings.Value; // Assign value to the field
        }

        // Show Bills for the Logged-in User
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Login", "Account");

            var bills = _context.Bills.Where(b => b.UserId == user.Id && b.IsActive).ToList();
            return View(bills);
        }

        // Redirect to Payment Gateway
        public async Task<IActionResult> Pay(int id)
        {
            var bill = await _context.Bills.FindAsync(id);
            if (bill == null) return NotFound();

            return RedirectToAction("Checkout", new { billId = bill.BillId });
        }

        public async Task<IActionResult> Checkout(int billId)
        {
            var bill = await _context.Bills.FindAsync(billId);
            if (bill == null) return NotFound();

            var domain = "https://yourwebsite.com";
            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string> { "card" },
                LineItems = new List<SessionLineItemOptions>
                {
                    new SessionLineItemOptions
                    {
                        PriceData = new SessionLineItemPriceDataOptions
                        {
                            Currency = "usd",
                            UnitAmount = (long)(bill.TotalAmount * 100), // Convert to cents
                            ProductData = new SessionLineItemPriceDataProductDataOptions
                            {
                                Name = "Homeowner Dues"
                            }
                        },
                        Quantity = 1
                    }
                },
                Mode = "payment",
                SuccessUrl = $"{domain}/Billing/ConfirmPayment?billId={bill.BillId}",
                CancelUrl = $"{domain}/Billing"
            };

            var service = new SessionService();
            var session = await service.CreateAsync(options);

            return Redirect(session.Url);
        }

        public async Task<IActionResult> ConfirmPayment(int billId)
        {
            var bill = await _context.Bills.FindAsync(billId);
            if (bill != null)
            {
                bill.Status = "Paid";
                bill.PaidAmount = bill.TotalAmount;
                bill.BalanceAmount = 0;
                bill.PaidDate = DateTime.UtcNow;
                bill.UpdatedAt = DateTime.UtcNow;
                bill.PaymentReference = Guid.NewGuid().ToString();
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
    }
}
