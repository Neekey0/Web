using Microsoft.AspNetCore.Mvc;

namespace Webb.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
