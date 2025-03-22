using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Hometown_Application.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using Hometown_Application.Data;
using Hometown_Application.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Helpers;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace Hometown_Application.Controllers
{
    [Authorize]
    public class VehicleGatePassController : Controller
    {
        private readonly ApplicationDBContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public VehicleGatePassController(ApplicationDBContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: VehicleGatePass/Create
        public IActionResult Create()
        {
            return View();
        }

          // POST: VehicleGatePass/Create
          [HttpPost]
          [ValidateAntiForgeryToken]
          public async Task<IActionResult> Create(VehicleGatepassModel model,IFormFile vehicleImage)
          {
              var user = await _userManager.GetUserAsync(User);
              if (user == null) return RedirectToAction("Index");

         if (vehicleImage != null && vehicleImage.Length > 0)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await vehicleImage.CopyToAsync(memoryStream);
                        model.VehicleImage = memoryStream.ToArray();
                    }
                }
              model.UserId = user.Id;
              model.AddedOn = DateTime.UtcNow;
              model.AddedBy = user.Id;
              _context.VehicleGatepasses.Add(model);
              await _context.SaveChangesAsync();
              return RedirectToAction(nameof(Index));
          }
       
        /*
        [HttpPost]
        public async Task<IActionResult> Create(VehicleGatepassModel model, IFormFile vehicleImage)
        {
            if (ModelState.IsValid)
            {
                if (vehicleImage != null && vehicleImage.Length > 0)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await vehicleImage.CopyToAsync(memoryStream);
                        model.VehicleImage = memoryStream.ToArray();
                    }
                }

                _context.VehicleGatepasses.Add(model);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View(model);
        }
        */

        // GET: VehicleGatePass/Index
        public async Task<IActionResult> Index()
        {
            var vehicleGatePasses = await _context.VehicleGatepasses
                .Where(v => !v.IsDeleted)
                .Include(v => v.ApplicationUser)
                .ToListAsync();

            return View(vehicleGatePasses);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var vehicleGatePass = await _context.VehicleGatepasses
                .Include(v => v.ApplicationUser)
                .FirstOrDefaultAsync(v => v.VehicleId == id);

            if (vehicleGatePass == null)
            {
                return NotFound();
            }

            return View(vehicleGatePass);
        }

        // POST: VehicleGatePass/DeleteConfirmed/{id}
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, VehicleGatepassModel model)
        {
            var vehicleGatePass = await _context.VehicleGatepasses.FindAsync(id);
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Index");
            if (vehicleGatePass == null)
            {
                return NotFound();
            }

            vehicleGatePass.VehicleBrand = model.VehicleBrand;
            vehicleGatePass.VehicleColor = model.VehicleColor;
            vehicleGatePass.VehiclePlateNumber = model.VehiclePlateNumber;
            vehicleGatePass.UpdatedBy = user.Id;
            vehicleGatePass.UpdatedOn = DateTime.UtcNow;

            _context.Update(vehicleGatePass);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

            
        }





        // GET: VehicleGatePass/Delete/{id}
        public async Task<IActionResult> Delete(int id)
        {
            var vehicleGatePass = await _context.VehicleGatepasses
                .Include(v => v.ApplicationUser)
                .FirstOrDefaultAsync(v => v.VehicleId == id);

            if (vehicleGatePass == null)
            {
                return NotFound();
            }

            return View(vehicleGatePass);
        }


        // GET: VehicleGatePass/Approve/{id}
        public async Task<IActionResult> Approve(int id)
        {
            var vehicleGatePass = await _context.VehicleGatepasses
                .Include(v => v.ApplicationUser)
                .FirstOrDefaultAsync(v => v.VehicleId == id);

            if (vehicleGatePass == null)
            {
                return NotFound();
            }

            return View(vehicleGatePass);  // Display the vehicle gate pass to be approved
        }
        [HttpPost, ActionName("ApproveRejectConfirmed")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ApproveRejectConfirmed(int id, string action, string rejectionReason)
        {
            var vehicleGatePass = await _context.VehicleGatepasses.FindAsync(id);
            if (vehicleGatePass == null)
            {
                return NotFound();
            }

            if (action == "reject")
            {
                // Reject the gate pass
                vehicleGatePass.IsApproved = false;
                vehicleGatePass.RejectionReason = rejectionReason;
                vehicleGatePass.ApprovalStatus = "Rejected";
                vehicleGatePass.IsRejected = true;
            }
            else if (action == "approve")
            {
                // Approve the gate pass
                vehicleGatePass.IsApproved = true;
                vehicleGatePass.ApprovalStatus = "Approved";
                vehicleGatePass.ApprovalDate = DateTime.UtcNow;
                vehicleGatePass.GatePassIssuedDate = DateTime.UtcNow;
                vehicleGatePass.IsRejected = false;

                // Automatically set expiry date to one year from the issued date
                vehicleGatePass.GatePassExpiryDate = DateTime.UtcNow.AddYears(1); // Set expiry to 1 year after issued date
            }
                
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index)); // Redirect back to the list after approval/rejection
        }



        [HttpPost]
        [ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        [Route("VehicleGatePass/DeleteConfirmed/{id}")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicleGatePass = await _context.VehicleGatepasses.FindAsync(id);
            if (vehicleGatePass == null)
            {
                return NotFound();
            }

            vehicleGatePass.IsDeleted = true; // Soft delete
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        /*   public async Task<IActionResult> GenerateGatePass(int id)
           {
               var user = await _userManager.GetUserAsync(User);
               // Fetch vehicle data from the database asynchronously
               var vehicle = await _context.VehicleGatepasses
                   .Where(v => v.VehicleId == id)
                   .FirstOrDefaultAsync();

               if (vehicle == null)
               {
                   return NotFound();
               }

               // Create the PDF document
               var document = Document.Create(container =>
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
                               col.Item().Text("Hometown Security Department").FontSize(22).Bold();
                               col.Item().Text("Official Gate Pass").FontSize(18).Bold().Underline();
                               col.Item().Text($"Issued Date: {DateTime.Now.ToShortDateString()}").FontSize(12);
                           });

                       // Content Section
                       page.Content()
                           .PaddingVertical(20)
                           .Column(col =>
                           {
                               // Vehicle Information Box
                               col.Item()
                                   .Border(1)
                                   .BorderColor(Colors.Black)
                                   .Background(Colors.Grey.Lighten3)
                                   .Padding(10)
                                   .Column(innerCol =>
                                   {
                                       innerCol.Item().Text("Vehicle Details").FontSize(16).Bold().Underline();
                                       innerCol.Item().Text($"Vehicle ID: {user.UserName}").FontSize(14);
                                       innerCol.Item().Text($"Brand: {vehicle.VehicleBrand}").FontSize(14);
                                       innerCol.Item().Text($"Color: {vehicle.VehicleColor}").FontSize(14);
                                       innerCol.Item().Text($"Plate Number: {vehicle.VehiclePlateNumber}").FontSize(14);
                                   });

                               // Gate Pass Approval Status
                               col.Item().PaddingTop(10)
                                   .Border(1)
                                   .BorderColor(Colors.Black)
                                   .Padding(10)
                                   .Column(innerCol =>
                                   {
                                       innerCol.Item().Text("Gate Pass Information").FontSize(16).Bold().Underline();
                                       innerCol.Item().Text($"Approval Status: {vehicle.ApprovalStatus}").FontSize(14).Bold();
                                       innerCol.Item().Text($"Issued Date: {vehicle.GatePassIssuedDate?.ToShortDateString()}").FontSize(14);
                                       innerCol.Item().Text($"Expiry Date: {vehicle.GatePassExpiryDate?.ToShortDateString()}").FontSize(14);
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
                           .Text("Generated by the Hometown Gate Pass System")
                           .FontSize(10)
                           .Italic();
                   });
               });

               // Convert PDF to bytes
               var pdfBytes = document.GeneratePdf();

               // Return PDF as a preview in the browser
               return File(pdfBytes, "application/pdf");
           }*/
        private async Task<IDocument> GenerateGatePassDocument(VehicleGatepassModel vehicle)
        {
            var user = await _userManager.GetUserAsync(User);

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
    .Width(100) // Set width first
    .Height(100) // Optional, to maintain proportions
    .Image("wwwroot/images/picc.png");



                            col.Item().Element(x => x.PaddingBottom(5))
                                .Text("Golden Haven Security Department").FontSize(22).Bold();
                            col.Item().Element(x => x.PaddingBottom(10))
                                .Text("Official Vehicle Gate Pass").FontSize(18).Bold().Underline();
                            col.Item().Text($"Issued Date: {DateTime.Now.ToShortDateString()}").FontSize(12);
                        });

                    // Content Section
                    page.Content()
                        .PaddingVertical(20)
                        .Column(col =>
                        {
                            // Vehicle Information Box
                            col.Item()
                                .Border(1)
                                .BorderColor(Colors.Black)
                                .Background(Colors.Grey.Lighten3)
                                .Padding(10)
                                .Column(innerCol =>
                                {
                                    innerCol.Item().Element(x => x.PaddingBottom(5))
                                        .Text("🚗 Vehicle Details").FontSize(16).Bold().Underline();
                                    innerCol.Item().Text($"🆔 Vehicle Owner: {user.FirstName} {user.LastName}").FontSize(14);
                                    innerCol.Item().Text($"🚘 Vehicle Type: {vehicle.VehicleType}").FontSize(14);
                                    innerCol.Item().Text($"🚙 Vehicle Brand: {vehicle.VehicleBrand}").FontSize(14);
                                    innerCol.Item().Text($"🎨 Vehicle Color: {vehicle.VehicleColor}").FontSize(14);
                                    innerCol.Item().Text($"🔖 Plate Number: {vehicle.VehiclePlateNumber}").FontSize(14);
                                });

                            // Gate Pass Approval Status
                            col.Item().PaddingTop(10)
                                .Border(1)
                                .BorderColor(Colors.Black)
                                .Padding(10)
                               .Column(innerCol =>
                               {
                                   innerCol.Item().Element(x => x.PaddingBottom(5))
                                       .Text("🔑 Gate Pass Information").FontSize(16).Bold().Underline();
                                   innerCol.Item().Text($"✅ Approval Status: {vehicle.ApprovalStatus}").FontSize(14).Bold();
                                   innerCol.Item().Text($"📅 Issued Date: {vehicle.GatePassIssuedDate?.ToShortDateString()}").FontSize(14);
                                   innerCol.Item().Text($"📆 Expiry Date: {vehicle.GatePassExpiryDate?.ToShortDateString()}").FontSize(14);
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



public async Task<IActionResult> DownloadPDF(int id)
{
    var vehicle = await _context.VehicleGatepasses
        .Where(v => v.VehicleId == id)
        .FirstOrDefaultAsync();

    if (vehicle == null)
    {
        return NotFound();
    }

    var document = await GenerateGatePassDocument(vehicle); // Await the document creation

    var pdfBytes = document.GeneratePdf(); // Generate PDF from the document

    return File(pdfBytes, "application/pdf", $"GatePass_{vehicle.VehiclePlateNumber}.pdf");
}


        /*
        public async Task<IActionResult> DownloadPDF(int id)
        {
            // Fetch the vehicle details from the database
            var vehicle = await _context.VehicleGatepasses
                .Where(v => v.VehicleId == id)
                .FirstOrDefaultAsync();

            if (vehicle == null)
            {
                return NotFound();
            }

            // Generate the PDF document
            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(30);
                    page.DefaultTextStyle(x => x.FontSize(14));

                    // Header - Organization Name
                    page.Header()
                        .AlignCenter()
                        .Column(col =>
                        {
                            col.Item().Text("Hometown Security Department").FontSize(22).Bold();
                            col.Item().Text("Official Gate Pass").FontSize(18).Bold().Underline();
                            col.Item().Text($"Issued Date: {DateTime.Now.ToShortDateString()}").FontSize(12);
                        });

                    // Content Section
                    page.Content()
                        .PaddingVertical(20)
                        .Column(col =>
                        {
                            // Vehicle Information Section
                            col.Item()
                                .Border(1)
                                .BorderColor(Colors.Black)
                                .Background(Colors.Grey.Lighten3)
                                .Padding(10)
                                .Column(innerCol =>
                                {
                                    innerCol.Item().Text("Vehicle Details").FontSize(16).Bold().Underline();
                                    innerCol.Item().Text($"Vehicle ID: {vehicle.VehicleId}").FontSize(14);
                                    innerCol.Item().Text($"Brand: {vehicle.VehicleBrand}").FontSize(14);
                                    innerCol.Item().Text($"Color: {vehicle.VehicleColor}").FontSize(14);
                                    innerCol.Item().Text($"Plate Number: {vehicle.VehiclePlateNumber}").FontSize(14);
                                });

                            // Gate Pass Approval Status Section
                            col.Item().PaddingTop(10)
                                .Border(1)
                                .BorderColor(Colors.Black)
                                .Padding(10)
                                .Column(innerCol =>
                                {
                                    innerCol.Item().Text("Gate Pass Information").FontSize(16).Bold().Underline();
                                    innerCol.Item().Text($"Approval Status: {vehicle.ApprovalStatus}").FontSize(14).Bold();
                                    innerCol.Item().Text($"Issued Date: {vehicle.GatePassIssuedDate?.ToShortDateString()}").FontSize(14);
                                    innerCol.Item().Text($"Expiry Date: {vehicle.GatePassExpiryDate?.ToShortDateString()}").FontSize(14);
                                });

                            // Signature Section
                            col.Item().PaddingTop(20).AlignCenter().Column(innerCol =>
                            {
                                innerCol.Item().Text("________________________").FontSize(14);
                                innerCol.Item().Text("Security Officer").FontSize(12).Italic();
                            });
                        });

                    // Footer
                    page.Footer()
                        .AlignCenter()
                        .Text("Generated by the Hometown Gate Pass System")
                        .FontSize(10)
                        .Italic();
                });
            });

            // Convert to PDF bytes
            var pdfBytes = document.GeneratePdf();

            // Return as a downloadable file
            return File(pdfBytes, "application/pdf", $"GatePass_{vehicle.VehiclePlateNumber}.pdf");

        }
        */  
    }
}
