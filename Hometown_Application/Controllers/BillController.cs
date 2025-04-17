using Microsoft.AspNetCore.Mvc;
using Hometown_Application.Models;
using Hometown_Application.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System;
using Hometown_Application.Data;
using Microsoft.EntityFrameworkCore;
using Hometown_Application.ViewModel;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.IO;


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
            var totalBillsByDuration = await _context.BillItems
                .Where(bi => !bi.IsDeleted)
                .GroupBy(bi => bi.PaymentDuration)
                .Select(g => new
                {
                    PaymentDuration = g.Key,
                    TotalAmount = g.Sum(bi => bi.Amount ?? 0)
                })
                .ToListAsync();

            // Extract totals for each payment duration
            var totalMonthlyBills = totalBillsByDuration.FirstOrDefault(b => b.PaymentDuration == "Monthly")?.TotalAmount ?? 0;
            var totalYearlyBills = totalBillsByDuration.FirstOrDefault(b => b.PaymentDuration == "Yearly")?.TotalAmount ?? 0;
            var totalQuarterlyBills = totalBillsByDuration.FirstOrDefault(b => b.PaymentDuration == "Quarterly")?.TotalAmount ?? 0;

            // Step 2: Get total number of homeowners
            var totalHomeowners = await _userManager.GetUsersInRoleAsync("HomeOwner");

            // Step 3: Set ViewBag for total bills by duration * number of homeowners
            ViewBag.TotalMonthlyBills = totalMonthlyBills * totalHomeowners.Count;
            ViewBag.TotalYearlyBills = totalYearlyBills * totalHomeowners.Count;
            ViewBag.TotalQuarterlyBills = totalQuarterlyBills * totalHomeowners.Count;

            // Step 4: Get all bills including user info
            var bills = await _context.Bills.Include(b => b.ApplicationUser).ToListAsync();

            // Get current month and year
            var currentMonth = DateTime.UtcNow.Month;
            var currentYear = DateTime.UtcNow.Year;

            // Step 5: Count users who have fully paid in the current month
            var fullyPaidUserCount = bills
                .Where(b => b.IssueDate.Month == currentMonth &&
                            b.IssueDate.Year == currentYear &&
                            b.RemainingBalance <= 0)
                .Select(b => b.UserId)
                .Distinct()
                .Count();

            // Step 6: Calculate total collected this month
            var totalCollectedThisMonth = bills
                .Where(b => b.IssueDate.Month == currentMonth &&
                            b.IssueDate.Year == currentYear)
                .Sum(b => b.TotalAmount - b.RemainingBalance);

            ViewBag.FullyPaidUserCount = fullyPaidUserCount;
            ViewBag.TotalCollectedThisMonth = totalCollectedThisMonth;

            // Step 7: Pass bills list to the view
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
        public async Task<IActionResult> PayBill(int billId, decimal amountPaid, string paymentMethod, string referenceNumber)
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

            // Fetch bills for the logged-in user
            var bills = await _context.Bills
                .Where(b => b.UserId == user.Id)
                .ToListAsync();

            // Fetch assignments and payments
           var billAssignments = await _context.BillAssignment
    .Where(ba => ba.UserId == user.Id)
    .Include(ba => ba.Bill) // Make sure Bill is included if necessary
    .ToListAsync();


            var payments = await _context.BillPayment
                .Where(p => p.Bill.UserId == user.Id)
                .Include(p => p.Bill)
                .ToListAsync();

            var viewModel = new List<HomeownerBoardViewModel>();

            foreach (var b in bills)
            {
                var relatedAssignments = billAssignments
                    .Where(ba => ba.BillId == b.BillId)
                    .ToList();

                var relatedPayments = payments
                    .Where(p => p.BillId == b.BillId)
                    .ToList();

                // No payments
                if (!relatedPayments.Any())
                {
                    viewModel.Add(new HomeownerBoardViewModel
                    {
                        BillId = b.BillId,
                        RemainingBalance = b.RemainingBalance,
                        Status = b.Status,
                        BillName = relatedAssignments.FirstOrDefault()?.BillName,
                        Amount = relatedAssignments.FirstOrDefault()?.Amount ?? 0,
                        Description = relatedAssignments.FirstOrDefault()?.Description,
                        DueDate = relatedAssignments.FirstOrDefault()?.DueDate ?? DateTime.MinValue,
                        BillAssignments = relatedAssignments
                    });
                }
                else
                {
                    foreach (var p in relatedPayments)
                    {
                        viewModel.Add(new HomeownerBoardViewModel
                        {
                            BillId = b.BillId,
                            RemainingBalance = b.RemainingBalance,
                            Status = b.Status,
                            BillName = relatedAssignments.FirstOrDefault()?.BillName,
                            Amount = relatedAssignments.FirstOrDefault()?.Amount ?? 0,
                            Description = relatedAssignments.FirstOrDefault()?.Description,
                            DueDate = relatedAssignments.FirstOrDefault()?.DueDate ?? DateTime.MinValue,
                            PaymentId = p.PaymentId,
                            PaymentDate = p.PaymentDate,
                            AmountPaid = p.AmountPaid,
                            PaymentMethod = p.PaymentMethod,
                            ReferenceNumber = p.ReferenceNumber,
                            IsApproved = p.IsApproved,
                            BillAssignments = relatedAssignments
                        });
                    }
                }
            }

            // You can keep filtering if you need
            var filteredViewModel = viewModel
                .Where(b => b.RemainingBalance > 0 && b.PaymentId != 0)
                .ToList();

            return View(viewModel); // You can also return filteredViewModel if needed
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

            // Get the current month and year
            var currentMonth = DateTime.UtcNow.Month;
            var currentYear = DateTime.UtcNow.Year;

            // Calculate total bill amount from active bill items
            var totalAmount = _context.BillItems
                              .Where(b => !b.IsDeleted)
                              .Sum(b => b.Amount) ?? 0;

            foreach (var homeowner in homeowners)
            {
                // Check if a bill already exists for this user in the current month
                bool billExists = _context.Bills.Any(b =>
                    b.UserId == homeowner.Id &&
                    b.IssueDate.Month == currentMonth &&
                    b.IssueDate.Year == currentYear);

                if (billExists)
                {
                    continue; // Skip this homeowner
                }

                // Create a new BillModel if no duplicate
                var newBill = new BillModel
                {
                    UserId = homeowner.Id,
                    IssueDate = DateTime.UtcNow,
                    DueDate = DateTime.UtcNow.AddDays(30),
                    TotalAmount = totalAmount,
                    RemainingBalance = totalAmount,
                    Status = "Pending",
                    Remarks = "Automatic Bill Assignment"
                };

                _context.Bills.Add(newBill);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("AdminBoard");
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
                     .ThenInclude(b => b.ApplicationUser)
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


        [HttpGet]
        public IActionResult DownloadConfirmationSlip(int paymentId)
        {
            var payment = _context.BillPayment
                .Include(p => p.Bill)
                .ThenInclude(b => b.ApplicationUser)
                .FirstOrDefault(p => p.PaymentId == paymentId && p.IsApproved);

            if (payment == null)
            {
                return NotFound("Approved payment not found.");
            }

            // Load logo image from wwwroot or elsewhere (adjust the path as needed)
            var logoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "logo.png");
            var logoImage = System.IO.File.Exists(logoPath) ? System.IO.File.ReadAllBytes(logoPath) : null;

            var pdfBytes = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(40);
                    page.DefaultTextStyle(x => x.FontSize(12).FontFamily("Georgia"));

                    // Header with logo and title
                    page.Header().Row(row =>
                    {
                        row.RelativeItem(1).Height(80).AlignMiddle().AlignLeft().Image(logoImage, ImageScaling.FitHeight);
                        row.RelativeItem(3).Column(col =>
                        {
                            col.Item().Text("HOMETOWN COMMUNITY ASSOCIATION")
                                .FontSize(18).Bold().AlignRight().FontColor(Colors.Blue.Darken3);
                            col.Item().Text("Payment Confirmation Slip")
                                .FontSize(16).SemiBold().AlignRight().FontColor(Colors.Grey.Darken1);
                            col.Item().Text($"Date Issued: {DateTime.Now:MMMM dd, yyyy}")
                                .FontSize(12).AlignRight().FontColor(Colors.Grey.Lighten1);
                        });
                    });

                    page.Content().Column(col =>
                    {
                        col.Item().PaddingVertical(15).LineHorizontal(1).LineColor(Colors.Grey.Lighten2);

                        col.Item().PaddingBottom(12).Text("Payment Details")
                            .FontSize(14).Bold().Underline().FontColor(Colors.Blue.Darken1);

                        col.Item().Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(160);
                                columns.RelativeColumn();
                            });

                            void AddRow(string label, string value)
                            {
                                table.Cell().PaddingVertical(6).PaddingHorizontal(8).Text(label).SemiBold().FontColor(Colors.Grey.Darken2);
                                table.Cell().PaddingVertical(6).PaddingHorizontal(8).Text(value).FontColor(Colors.Black);
                            }

                            AddRow("Homeowner Name:", $"{payment.Bill.ApplicationUser.FirstName} {payment.Bill.ApplicationUser.LastName}");
                            AddRow("Bill ID:", payment.BillId.ToString());
                            AddRow("Payment Date:", payment.PaymentDate.ToString("MMMM dd, yyyy"));
                            AddRow("Amount Paid:", payment.AmountPaid.ToString("C"));
                            AddRow("Payment Method:", payment.PaymentMethod);
                            AddRow("Reference Number:", payment.ReferenceNumber);
                            AddRow("Payment Status:", "Approved");
                        });

                        col.Item().PaddingTop(20).Text("This slip serves as formal confirmation of your successful payment to the Hometown Community Association. Please keep this document for your records.")
                            .FontSize(12).FontColor(Colors.Grey.Darken1);

                        col.Item().PaddingTop(25).Text("For any concerns or inquiries, you may reach out to our office through the contact information provided below.")
                            .FontSize(11).Italic().FontColor(Colors.Grey.Darken2);
                    });

                    page.Footer().AlignCenter().Text(text =>
                    {
                        text.Span("Hometown Community Association")
                            .SemiBold()
                            .FontSize(10)
                            .FontColor(Colors.Grey.Darken1);
                        text.Span(" | ");
                        text.Span("Contact: (123) 456-7890 | Email: info@hometownhoa.org")
                            .Italic()
                            .FontSize(10)
                            .FontColor(Colors.Grey.Darken1);
                    });

                });
            }).GeneratePdf();

            return File(pdfBytes, "application/pdf", $"ConfirmationSlip_Payment_{payment.PaymentId}.pdf");
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