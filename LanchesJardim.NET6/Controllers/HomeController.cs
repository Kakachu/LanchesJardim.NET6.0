using LanchesJardim.NET6.Repositories.Interfaces;
using LanchesJardim.NET6.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesJardim.NET6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public HomeController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult Index()
        {
            var homeVM = new HomeViewModel
            {
                LanchesPreferidos = _lancheRepository.LanchesPreferidos
            };
            return View(homeVM);
        }
    }
}
