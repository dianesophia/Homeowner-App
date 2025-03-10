using Hometown_Application.Data;
using Hometown_Application.Models;
using Hometown_Application.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;

namespace Hometown_Application.Seed
{
    public static class StaffProfileSeeder
    {
        public static void Seed(ApplicationDBContext context, UserManager<ApplicationUser> userManager)
        {
            if (!context.StaffProfiles.Any()) // Prevent duplicate seeding
            {
                var staffMembers = new[]
                {
                    // 🖥️ IT Department - Elon Musk & Mark Zuckerberg
                    new StaffProfileModel
                    {
                        UserId = CreateUser(userManager, "elon.musk@example.com", "Elon", "Musk"),
                        Department = StaffDepartment.IT,
                        Position = "Senior Software Engineer",
                        HireDate = new DateTime(2022, 6, 1),
                        Salary = 120000.00m
                    },
                    new StaffProfileModel
                    {
                        UserId = CreateUser(userManager, "mark.zuckerberg@example.com", "Mark", "Zuckerberg"),
                        Department = StaffDepartment.IT,
                        Position = "CTO",
                        HireDate = new DateTime(2021, 5, 15),
                        Salary = 150000.00m
                    },

                    // 🏢 Customer Support
                    new StaffProfileModel
                    {
                        UserId = CreateUser(userManager, "jane.doe@example.com", "Jane", "Doe"),
                        Department = StaffDepartment.CustomerSupport,
                        Position = "Support Representative",
                        HireDate = new DateTime(2023, 2, 10),
                        Salary = 50000.00m
                    },

                    // 💰 Finance
                    new StaffProfileModel
                    {
                        UserId = CreateUser(userManager, "john.smith@example.com", "John", "Smith"),
                        Department = StaffDepartment.Finance,
                        Position = "Finance Manager",
                        HireDate = new DateTime(2020, 8, 20),
                        Salary = 90000.00m
                    },

                    // 🌳 Landscaping
                    new StaffProfileModel
                    {
                        UserId = CreateUser(userManager, "maria.garcia@example.com", "Maria", "Garcia"),
                        Department = StaffDepartment.Landscaping,
                        Position = "Head Gardener",
                        HireDate = new DateTime(2019, 4, 5),
                        Salary = 40000.00m
                    },

                    // 🔧 Maintenance
                    new StaffProfileModel
                    {
                        UserId = CreateUser(userManager, "robert.brown@example.com", "Robert", "Brown"),
                        Department = StaffDepartment.Maintenance,
                        Position = "Maintenance Supervisor",
                        HireDate = new DateTime(2018, 11, 12),
                        Salary = 55000.00m
                    },

                    // 🚨 Security
                    new StaffProfileModel
                    {
                        UserId = CreateUser(userManager, "lisa.johnson@example.com", "Lisa", "Johnson"),
                        Department = StaffDepartment.Security,
                        Position = "Security Officer",
                        HireDate = new DateTime(2022, 7, 30),
                        Salary = 45000.00m
                    }
                };

                context.StaffProfiles.AddRange(staffMembers);
                context.SaveChanges();
            }
        }

        private static string CreateUser(UserManager<ApplicationUser> userManager, string email, string firstName, string lastName)
        {
            var user = userManager.FindByEmailAsync(email).Result;
            if (user == null)
            {
                user = new ApplicationUser
                {
                    UserName = email,
                    Email = email,
                    FirstName = firstName,
                    LastName = lastName,
                    EmailConfirmed = true
                };
                userManager.CreateAsync(user, "Password123!").Wait();
            }
            return user.Id;
        }
    }
}
