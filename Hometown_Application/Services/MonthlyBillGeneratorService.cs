using Microsoft.Extensions.Hosting;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Hometown_Application.Areas.Identity.Data;
using Hometown_Application.Data;
using Hometown_Application.Models;
using Microsoft.EntityFrameworkCore;
public class MonthlyBillGeneratorService : BackgroundService
{
    private readonly IServiceProvider _serviceProvider;

    public MonthlyBillGeneratorService(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDBContext>();

                var today = DateTime.UtcNow;

                // Only run on the 1st of every month
                if (today.Day == 1)  // This condition ensures it runs only on the 1st of each month
                {
                    var homeowners = await userManager.GetUsersInRoleAsync("Homeowner");

                    foreach (var user in homeowners)
                    {
                        // Prevent duplicate bills for the same month
                        bool alreadyBilled = dbContext.Bills.Any(b =>
                            b.UserId == user.Id &&
                            b.IssueDate.Month == today.Month &&
                            b.IssueDate.Year == today.Year
                        );

                        if (!alreadyBilled)
                        {
                            // Fetch the BillItems for the user
                            var billItems = dbContext.BillItems
                                .Where(bi => bi.PaymentDuration == "Monthly" && !bi.IsDeleted)
                                .ToList();

                            // Calculate the total amount using SumAsync, similar to your AdminBoard code
                            decimal totalAmount = await dbContext.BillItems
                            .Where(bi => bi.PaymentDuration == "Monthly" && !bi.IsDeleted)
                            .SumAsync(bi => bi.Amount ?? 0m);

                            var bill = new BillModel
                            {
                                UserId = user.Id,
                                IssueDate = today,
                                DueDate = today.AddDays(30),
                                TotalAmount = totalAmount, // Set total amount based on BillItems
                               // RemainingBalance = totalAmount,  // Set the same initial value
                                Status = "Pending",
                                Remarks = "Auto-generated bill"
                            };

                            dbContext.Bills.Add(bill);
                        }
                    }

                    await dbContext.SaveChangesAsync();
                }
            }

            // Delay for 24 hours before checking again
            await Task.Delay(TimeSpan.FromHours(24), stoppingToken);
        }
    }

}

