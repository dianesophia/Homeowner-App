using Hometown_Application.Models;

public class VehicleGatePassIndexViewModel
{
    public List<VehicleGatepassModel> Approved { get; set; }
    public List<VehicleGatepassModel> Pending { get; set; }
    public List<VehicleGatepassModel> Rejected { get; set; }
}
