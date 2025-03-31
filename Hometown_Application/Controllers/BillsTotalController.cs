    using Microsoft.AspNetCore.Mvc;
    using System.Linq;
    using Hometown_Application.Data;
    using Hometown_Application.Models;
    using QuestPDF.Fluent;
    using QuestPDF.Helpers;
    using QuestPDF.Infrastructure;
    using System;

    public class BillsTotalController : Controller
    {
        private readonly ApplicationDBContext _context;

        public BillsTotalController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var billItems = _context.BillItems.Where(b => !b.IsDeleted).ToList();

            decimal totalOutstandingBalance = billItems.Where(b => b.Amount.HasValue).Sum(b => b.Amount.Value);
            decimal totalMonthly = billItems.Where(b => b.PaymentDuration == "Monthly" && b.Amount.HasValue).Sum(b => b.Amount.Value);
            decimal totalQuarterly = billItems.Where(b => b.PaymentDuration == "Quarterly" && b.Amount.HasValue).Sum(b => b.Amount.Value);
            decimal totalYearly = billItems.Where(b => b.PaymentDuration == "Yearly" && b.Amount.HasValue).Sum(b => b.Amount.Value);

            ViewBag.TotalOutstandingBalance = totalOutstandingBalance;
            ViewBag.TotalMonthly = totalMonthly;
            ViewBag.TotalQuarterly = totalQuarterly;
            ViewBag.TotalYearly = totalYearly;

            return View(billItems);
        }
        public IActionResult DownloadFeesLiquidationPdf()
        {
            var bills = _context.BillItems.Where(b => !b.IsDeleted).ToList();

            decimal totalOutstanding = bills.Where(b => b.Amount.HasValue).Sum(b => b.Amount.Value);
            decimal totalMonthly = bills.Where(b => b.PaymentDuration == "Monthly" && b.Amount.HasValue).Sum(b => b.Amount.Value);
            decimal totalQuarterly = bills.Where(b => b.PaymentDuration == "Quarterly" && b.Amount.HasValue).Sum(b => b.Amount.Value);
            decimal totalYearly = bills.Where(b => b.PaymentDuration == "Yearly" && b.Amount.HasValue).Sum(b => b.Amount.Value);

            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(595, 935); // Small bond paper (8.5" x 13")
                    page.Margin(20);
                    page.DefaultTextStyle(x => x.FontSize(10).FontFamily("Arial"));

                    page.Header().Column(col =>
                    {
                        col.Item().Row(row =>
                        {
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().Text("Golden Haven Association").FontSize(14).Bold();
                                col.Item().Text("123 Street, City, Country").FontSize(9);
                                col.Item().Text("Email: contact@hoa.com | Phone: 123-456-7890").FontSize(9);
                            });

                            row.ConstantItem(80).Image("wwwroot/images/picc.png").FitWidth();
                        });

                        col.Item().AlignRight().Text($"Report Date: {DateTime.Now:yyyy-MM-dd}").FontSize(9);
                        col.Item().AlignRight().Text($"Reference #: HOA-{new Random().Next(1000, 9999)}").FontSize(9).Bold();
                    });

                    page.Content().Column(col =>
                    {
                        col.Spacing(10);
                        col.Item().AlignCenter().Text("Homeowner Fees Liquidation Report").FontSize(12).Bold().FontColor(Colors.Blue.Darken2);
                        col.Item().Element(e => e.LineHorizontal(1).LineColor(Colors.Grey.Lighten2));

                        col.Item().Text("Summary of Fees:").FontSize(11).Bold();
                        col.Item().Row(summary =>
                        {
                            summary.RelativeItem().Text($"Total Monthly Fees: {totalMonthly:C}").FontSize(10);
                            summary.RelativeItem().Text($"Total Quarterly Fees: {totalQuarterly:C}").FontSize(10);
                            summary.RelativeItem().Text($"Total Yearly Fees: {totalYearly:C}").FontSize(10);
                        });

                        col.Item().Text($"Overall Total: {totalOutstanding:C}").FontSize(11).Bold().FontColor(Colors.Red.Darken2);
                        col.Item().Element(e => e.LineHorizontal(1).LineColor(Colors.Grey.Lighten2));

                        col.Item().Text("Breakdown of Fees:").FontSize(11).Bold();
                        col.Item().Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(2); // Fee Type
                                columns.RelativeColumn(4); // Description
                                columns.ConstantColumn(70); // Amount
                                columns.ConstantColumn(70); // Frequency
                                columns.ConstantColumn(80); // Date
                            });

                            table.Header(header =>
                            {
                                header.Cell().Element(e => e.Text("Fee Type").Bold().FontSize(10));
                                header.Cell().Element(e => e.Text("Description").Bold().FontSize(10));
                                header.Cell().Element(e => e.Text("Amount").Bold().FontSize(10).AlignRight());
                                header.Cell().Element(e => e.Text("Frequency").Bold().FontSize(10).AlignCenter());
                                header.Cell().Element(e => e.Text("Recorded On").Bold().FontSize(10).AlignCenter());

                                header.Cell().BorderBottom(1).BorderColor(Colors.Black);
                                header.Cell().BorderBottom(1).BorderColor(Colors.Black);
                                header.Cell().BorderBottom(1).BorderColor(Colors.Black);
                                header.Cell().BorderBottom(1).BorderColor(Colors.Black);
                                header.Cell().BorderBottom(1).BorderColor(Colors.Black);
                            });

                            foreach (var bill in bills)
                            {
                                table.Cell().Element(e => e.Text(bill.PaymentName).FontSize(9));
                                table.Cell().Element(e => e.Text(bill.Description).FontSize(9));
                                table.Cell().Element(e => e.Text(bill.Amount?.ToString("C")).FontSize(9).AlignRight());
                                table.Cell().Element(e => e.Text(bill.PaymentDuration).FontSize(9).AlignCenter());
                                table.Cell().Element(e => e.Text(bill.AddedOn.ToString("yyyy-MM-dd")).FontSize(9).AlignCenter());
                            }
                        });

                        col.Item().Element(e => e.LineHorizontal(1).LineColor(Colors.Grey.Lighten2));
                        col.Item().Text("Notes & Clarifications:").FontSize(10).Bold();
                        col.Item().Text("This liquidation report provides a detailed breakdown of the outstanding fees. If you have any questions, please contact the HOA office.");
                    });

                    page.Footer().AlignCenter().Text($"Generated on: {DateTime.Now:yyyy-MM-dd HH:mm}").FontSize(9);
                });
            });

            byte[] pdfBytes = document.GeneratePdf();
            return File(pdfBytes, "application/pdf", "Fees_Liquidation_Report.pdf");
        }

    }