using Microsoft.AspNetCore.Mvc;

namespace AgriEnergyConnect.Controllers
{
    public class HomeController : Controller
    {
        // Action for the home/index page
        public IActionResult Index()
        {
            return View();
        }

        // Action for the privacy policy page
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
