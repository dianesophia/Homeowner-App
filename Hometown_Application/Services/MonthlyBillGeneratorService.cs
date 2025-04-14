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
                var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDBContext>();
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

                var today = DateTime.UtcNow;

                // Only run on the 1st of every month
                if (today.Day == 1)
                {
                    var homeowners = await userManager.GetUsersInRoleAsync("HomeOwner");

                    foreach (var user in homeowners)
                    {
                        bool alreadyBilled = dbContext.Bills.Any(b =>
                            b.UserId == user.Id &&
                            b.IssueDate.Month == today.Month &&
                            b.IssueDate.Year == today.Year
                        );

                        if (!alreadyBilled)
                        {
                            var billItems = dbContext.BillItems
                                .Where(bi => bi.PaymentDuration == "Monthly" && !bi.IsDeleted)
                                .ToList();

                            decimal totalAmount = await dbContext.BillItems
                                .Where(bi => bi.PaymentDuration == "Monthly" && !bi.IsDeleted)
                                .SumAsync(bi => bi.Amount ?? 0m);

                            var bill = new BillModel
                            {
                                UserId = user.Id,
                                IssueDate = today,
                                DueDate = today.AddDays(30),
                                TotalAmount = totalAmount,
                                Status = "Pending",
                                Remarks = "Auto-generated bill"
                            };

                            dbContext.Bills.Add(bill);
                        }
                    }

                    await dbContext.SaveChangesAsync();
                }
            }

            await Task.Delay(TimeSpan.FromHours(24), stoppingToken);
        }
    }
}
