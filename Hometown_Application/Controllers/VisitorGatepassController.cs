using Hometown_Application.Areas.Identity.Data;
using Hometown_Application.Data;
using Hometown_Application.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Helpers;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace Hometown_Application.Controllers
{
    public class VisitorGatepassController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public VisitorGatepassController(ApplicationDBContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        public async Task<IActionResult> Index()
        {
            var visitorGatepasses = await _context.VisitorGatepasses
                .Where(v => v.IsDeleted == false) // Exclude soft-deleted entries
                .Include(v => v.ApplicationUser)
                .ToListAsync();

            return View(visitorGatepasses);
        }

        public IActionResult Create()
        {
            return View();
        }
        // POST: VehicleGatePass/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VisitorGatepassModel model)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Index");

           
            model.UserId = user.Id;
            model.AddedOn = DateTime.UtcNow;
            model.AddedBy = user.Id;
            _context.VisitorGatepasses.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var visitorGatepass = await _context.VisitorGatepasses.FindAsync(id);
            if (visitorGatepass == null) return RedirectToAction("Index");
            return View(visitorGatepass);
        }

      

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, VisitorGatepassModel model) // ✅ Renamed method
        {
            if (id != model.VisitorId) // ✅ Ensure 'VisitorId' matches your model property
            {
                return BadRequest();
            }

            var visitorGatepass = await _context.VisitorGatepasses.FindAsync(id);
            if (visitorGatepass == null)
            {
                return NotFound();
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return Unauthorized();
            }

            // ✅ Update the properties
            visitorGatepass.VisitorName = model.VisitorName;
            visitorGatepass.Purpose = model.Purpose;
            visitorGatepass.VisitDate = model.VisitDate;
            visitorGatepass.NumberOfVisitors = model.NumberOfVisitors;
            visitorGatepass.ContactNumber = model.ContactNumber;
            visitorGatepass.UpdatedOn = DateTime.UtcNow;
            visitorGatepass.UpdatedBy = user.Id;

            try
            {
                _context.Update(visitorGatepass);
                await _context.SaveChangesAsync();
                TempData["Message"] = "Updated successfully!";
            }
            catch (DbUpdateConcurrencyException)
            {
                TempData["Message"] = "Failed to update. Please try again.";
            }

            return RedirectToAction(nameof(Index));
        }


        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var visitorGatepass = await _context.VisitorGatepasses.FindAsync(id);
            if (visitorGatepass == null)
            {
                TempData["Message"] = "Not found.";
                return RedirectToAction(nameof(Index));
            }

            visitorGatepass.IsDeleted = true; // Mark as deleted
            await _context.SaveChangesAsync();

            TempData["Message"] = "Deleted successfully!";
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Approve(int id)
        {
            var visitor = await _context.VisitorGatepasses.FindAsync(id);
            var user = await _userManager.GetUserAsync(User);
            if (visitor == null)
                return NotFound();

            visitor.ApprovalStatus = "Approved";
            visitor.ApprovedBy = user.Id;
            visitor.ApprovedDate = DateTime.UtcNow;
            visitor.GatePassExpiryDate = visitor.GatePassIssuedDate?.AddDays(7);
            visitor.IsApproved = true;
            visitor.IsRejected = false;
            visitor.GatePassIssuedDate = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Reject(int id, string adminNotes)
        {
            var visitor = await _context.VisitorGatepasses.FindAsync(id);
            if (visitor == null)
                return NotFound();

            visitor.ApprovalStatus = "Rejected";
            visitor.AdminNotes = adminNotes;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private async Task<IDocument> GenerateVisitorGatePassDocument(VisitorGatepassModel visitor)
        {
            return Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(30);
                    page.DefaultTextStyle(x => x.FontSize(14));

                    // Header Section
                    page.Header()
                        .AlignCenter()
                        .Column(col =>
                        {
                            col.Item()
                                .AlignCenter()
                                .Width(100)
                                .Height(100)
                                .Image("wwwroot/images/picc.png");

                            col.Item().Element(x => x.PaddingBottom(5))
                                .Text("Golden Haven Security Department").FontSize(22).Bold();
                            col.Item().Element(x => x.PaddingBottom(10))
                                .Text("Official Visitor Gate Pass").FontSize(18).Bold().Underline();
                            col.Item().Text($"Issued Date: {DateTime.Now.ToShortDateString()}").FontSize(12);
                        });

                    // Content Section
                    page.Content()
                        .PaddingVertical(20)
                        .Column(col =>
                        {
                            // Visitor Information Box
                            col.Item()
                                .Border(1)
                                .BorderColor(Colors.Black)
                                .Background(Colors.Grey.Lighten3)
                                .Padding(10)
                                .Column(innerCol =>
                                {
                                    innerCol.Item().Element(x => x.PaddingBottom(5))
                                        .Text("👤 Visitor Details").FontSize(16).Bold().Underline();
                                    innerCol.Item().Text($"🆔 Visitor Name: {visitor.VisitorName}").FontSize(14);
                                    innerCol.Item().Text($"📅 Visit Date: {visitor.VisitDate.ToShortDateString()}").FontSize(14);
                                    innerCol.Item().Text($"🎯 Purpose: {visitor.Purpose}").FontSize(14);
                                    innerCol.Item().Text($"👥 Number of Visitors: {visitor.NumberOfVisitors}").FontSize(14);
                                    innerCol.Item().Text($"📞 Contact Number: {visitor.ContactNumber}").FontSize(14);
                                });

                            // 🚗 Vehicle Information Box (NEW SECTION)
                            col.Item().PaddingTop(10)
                                .Border(1)
                                .BorderColor(Colors.Black)
                                .Background(Colors.Grey.Lighten3)
                                .Padding(10)
                                .Column(innerCol =>
                                {
                                    innerCol.Item().Element(x => x.PaddingBottom(5))
                                        .Text("🚗 Vehicle Details").FontSize(16).Bold().Underline();
                                    innerCol.Item().Text($"🚘 Vehicle Type: {visitor.VehicleType ?? "N/A"}").FontSize(14);
                                    innerCol.Item().Text($"🔢 Plate Number: {visitor.VehiclePlateNumber ?? "N/A"}").FontSize(14);
                                    innerCol.Item().Text($"🎨 Vehicle Color: {visitor.VehicleColor ?? "N/A"}").FontSize(14);
                                });

                            // Approval Status
                            col.Item().PaddingTop(10)
                                .Border(1)
                                .BorderColor(Colors.Black)
                                .Padding(10)
                                .Column(innerCol =>
                                {
                                    innerCol.Item().Element(x => x.PaddingBottom(5))
                                        .Text("🔑 Gate Pass Information").FontSize(16).Bold().Underline();
                                    innerCol.Item().Text($"✅ Approval Status: {visitor.ApprovalStatus}").FontSize(14).Bold();
                                    innerCol.Item().Text($"🛡️ Approved By: {visitor.ApprovedBy}").FontSize(14);
                                    innerCol.Item().Text($"📅 Issued Date: {visitor.GatePassIssuedDate?.ToShortDateString()}").FontSize(14);
                                    innerCol.Item().Text($"📆 Expiry Date: {visitor.GatePassExpiryDate?.ToShortDateString()}").FontSize(14);
                                });

                            // Signature Section
                            col.Item().PaddingTop(20).AlignCenter().Column(innerCol =>
                            {
                                innerCol.Item().Text("________________________").FontSize(14);
                                innerCol.Item().Text("Security Officer").FontSize(12).Italic();
                            });
                        });

                    // Footer Section
                    page.Footer()
                        .AlignCenter()
                        .Text("Generated by the Golden Haven Gate Pass System")
                        .FontSize(10)
                        .Italic();
                });
            });
        }



        public async Task<IActionResult> DownloadVisitorGatePass(int id)
        {
            var visitor = await _context.VisitorGatepasses
                .Where(v => v.VisitorId == id && v.ApprovalStatus == "Approved") // Only allow downloading if approved
                .FirstOrDefaultAsync();

            if (visitor == null)
            {
                return NotFound();
            }

            var document = await GenerateVisitorGatePassDocument(visitor); // Generate PDF document

            var pdfBytes = document.GeneratePdf(); // Convert to PDF

            return File(pdfBytes, "application/pdf", $"VisitorGatePass_{visitor.VisitorName}.pdf");
        }




    }
}
