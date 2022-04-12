using Microsoft.AspNetCore.Mvc;

namespace sitehero.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
