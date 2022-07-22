using Microsoft.AspNetCore.Mvc;

namespace LanchesJardim.NET6.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
