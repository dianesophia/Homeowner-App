using System.Collections.Generic;

namespace Hometown_Application.Models
{
    public static class RequestTypeSeeder
    {
        public static List<RequestTypeModel> GetDefaultRequestTypes()
        {
            return new List<RequestTypeModel>
            {
                new RequestTypeModel { Name = "Pool Maintenance", Description = "Cleaning and maintenance of the pool area", AssignedDepartment = StaffDepartment.Amenities },
                new RequestTypeModel { Name = "Gym Equipment Repair", Description = "Repairing faulty gym equipment", AssignedDepartment = StaffDepartment.Amenities },

                new RequestTypeModel { Name = "Billing Inquiry", Description = "Questions related to fees and payments", AssignedDepartment = StaffDepartment.Finance },
                new RequestTypeModel { Name = "Payment Dispute", Description = "Dispute over a transaction or charge", AssignedDepartment = StaffDepartment.Finance },

                new RequestTypeModel { Name = "Wi-Fi Issue", Description = "Problems with internet access in the community", AssignedDepartment = StaffDepartment.IT },
                new RequestTypeModel { Name = "Software Assistance", Description = "Help with community-related software or systems", AssignedDepartment = StaffDepartment.IT },

                new RequestTypeModel { Name = "Lawn Care", Description = "Trimming and maintaining the lawn", AssignedDepartment = StaffDepartment.Landscaping },
                new RequestTypeModel { Name = "Tree Trimming", Description = "Cutting overgrown tree branches", AssignedDepartment = StaffDepartment.Landscaping },

                new RequestTypeModel { Name = "Plumbing Repair", Description = "Fixing leaks and plumbing issues", AssignedDepartment = StaffDepartment.Maintenance },
                new RequestTypeModel { Name = "Electrical Repair", Description = "Fixing electrical issues in community areas", AssignedDepartment = StaffDepartment.Maintenance },

                new RequestTypeModel { Name = "Lost & Found", Description = "Reporting or retrieving lost items", AssignedDepartment = StaffDepartment.Security },
                new RequestTypeModel { Name = "Suspicious Activity", Description = "Reporting suspicious persons or activities", AssignedDepartment = StaffDepartment.Security },

                new RequestTypeModel { Name = "Complaint", Description = "Filing a general complaint about services", AssignedDepartment = StaffDepartment.CustomerSupport },
                new RequestTypeModel { Name = "General Inquiry", Description = "General questions about community services", AssignedDepartment = StaffDepartment.CustomerSupport }
            };
        }
    }
}
