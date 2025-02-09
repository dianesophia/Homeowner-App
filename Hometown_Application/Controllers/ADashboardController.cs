using Microsoft.AspNetCore.Mvc;

namespace Hometown_Application.Controllers
{
    public class ADashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
