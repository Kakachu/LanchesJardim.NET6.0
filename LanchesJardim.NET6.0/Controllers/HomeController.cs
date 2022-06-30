using Microsoft.AspNetCore.Mvc;

namespace LanchesJardim.NET6._0.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
