using Microsoft.AspNetCore.Mvc;

namespace Hometown_Application.Controllers
{
    public class FeedbackComplaintController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
