using Hometown_Application.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Hometown_Application.ViewModels
{
    public class ServiceRequestListViewModel
    {
        public List<ServiceRequestModel> Requests { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public string SortBy { get; set; }
        public bool Ascending { get; set; }
        public List<SelectListItem> Statuses { get; set; } // Added to hold the list of statuses
    }

    public class CreateServiceRequestViewModel
    {
        public ServiceRequestModel ServiceRequest { get; set; }
        public List<RequestTypeModel> RequestTypes { get; set; }
    }

    public class EditServiceRequestViewModel
    {
        public ServiceRequestModel ServiceRequest { get; set; }
        public List<SelectListItem> RequestTypes { get; set; }
        public List<SelectListItem> Statuses { get; set; }
    }
}