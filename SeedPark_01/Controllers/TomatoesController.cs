using Microsoft.AspNetCore.Mvc;

namespace SeedPark_01.Controllers
{
    public class TomatoesController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "This is the tomatoes page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}