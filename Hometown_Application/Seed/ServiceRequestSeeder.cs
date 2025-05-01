using Hometown_Application.Data;
using Hometown_Application.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Hometown_Application.Seed
{
    public class ServiceRequestSeeder
    {
        private readonly ApplicationDBContext _context;
        private readonly ILogger<ServiceRequestSeeder> _logger;

        public ServiceRequestSeeder(ApplicationDBContext context, ILogger<ServiceRequestSeeder> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task SeedAsync()
        {
            try
            {
                _logger.LogInformation("Starting service request seeding...");
                await SeedStatusesAsync();
                await SeedRequestTypesAsync();
                await SeedSampleServiceRequestsAsync(); // Uncomment this line
                _logger.LogInformation("Service request data seeded successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred during service request seeding.");
                throw;
            }
        }

        private async Task SeedStatusesAsync()
        {
            if (await _context.Status.AnyAsync())
            {
                _logger.LogInformation("Status table already seeded, skipping.");
                return;
            }

            _logger.LogInformation("Seeding Status table...");
            var statuses = new[]
            {
                new StatusModel { StatusName = "Pending" },
                new StatusModel { StatusName = "Confirmed" },
                new StatusModel { StatusName = "In Progress" },
                new StatusModel { StatusName = "Completed" },
                new StatusModel { StatusName = "Rejected" },
                new StatusModel { StatusName = "Cancelled" }
            };

            _context.Status.AddRange(statuses);
            await _context.SaveChangesAsync();

            _logger.LogInformation("Status table seeded successfully.");
        }

        private async Task SeedRequestTypesAsync()
        {
            if (await _context.RequestTypes.AnyAsync())
            {
                _logger.LogInformation("RequestTypes table already seeded, skipping.");
                return;
            }

            _logger.LogInformation("Seeding RequestTypes table...");
            var requestTypes = new[]
            {
                new RequestTypeModel
                {
                    Name = "Lawn Mowing",
                    Description = "Request lawn maintenance services.",
                    AssignedDepartment = StaffDepartment.Landscaping,
                    IsActive = true
                },
                new RequestTypeModel
                {
                    Name = "Pool Cleaning",
                    Description = "Request for pool maintenance.",
                    AssignedDepartment = StaffDepartment.Amenities,
                    IsActive = true
                },
                new RequestTypeModel
                {
                    Name = "HVAC Repair",
                    Description = "Request for heating or cooling system repair.",
                    AssignedDepartment = StaffDepartment.Maintenance,
                    IsActive = true
                }
            };

            _context.RequestTypes.AddRange(requestTypes);
            await _context.SaveChangesAsync();

            _logger.LogInformation("RequestTypes table seeded successfully.");
        }

        private async Task SeedSampleServiceRequestsAsync()
        {
            if (await _context.ServiceRequests.AnyAsync())
            {
                _logger.LogInformation("ServiceRequests table already seeded, skipping.");
                return;
            }

            _logger.LogInformation("Seeding sample ServiceRequests...");
            if (!await _context.Status.AnyAsync() || !await _context.RequestTypes.AnyAsync())
            {
                throw new InvalidOperationException("Statuses and RequestTypes must be seeded before seeding ServiceRequests.");
            }

            var pendingStatus = await _context.Status.FirstAsync(s => s.StatusName == "Pending");
            var lawnMowingRequestType = await _context.RequestTypes.FirstAsync(rt => rt.Name == "Lawn Mowing");

            var adminUser = await _context.Users.FirstAsync(u => u.Email == "admin@admin.com");

            var sampleRequests = new[]
            {
        new ServiceRequestModel
        {
            RequestTypeId = lawnMowingRequestType.RequestTypeId,
            StatusId = pendingStatus.StatusId,
            Details = "Please mow the front lawn.",
            Location = "123 Main St",
            Urgency = UrgencyLevel.Medium,
            Email = "admin@admin.com",
            Schedule = DateTime.UtcNow.AddDays(1),
            AddedOn = DateTime.UtcNow,
            AddedBy = "System",
            UserId = adminUser.Id,
            IsDeleted = false
        }
    };

            _context.ServiceRequests.AddRange(sampleRequests);
            await _context.SaveChangesAsync();

            _logger.LogInformation("Sample ServiceRequests table seeded successfully.");
        }
    }
}