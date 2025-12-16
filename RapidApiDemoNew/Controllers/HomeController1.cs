using Microsoft.AspNetCore.Mvc;

namespace RapidApiDemoNew.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
