using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PieShop.Models;
using PieShop.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            this.pieRepository = pieRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var pies = pieRepository.GetAllPies().OrderBy(p => p.Name).ToList();

            var viewModel = new HomeViewModel
            {
                Title = "Bethany's Pie Shop",
                Pies = pies
            };

            return View(viewModel);
        }

        public IActionResult Details(int id)
        {
            var pie = pieRepository.GetPieById(id);
            if (pie == null)
            {
                return NotFound();
            }
            return View(pie);
        }
    }
}
