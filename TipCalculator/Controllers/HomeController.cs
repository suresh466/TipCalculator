using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Tip15 = 0;
            ViewBag.Tip20 = 0;
            ViewBag.Tip25 = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(TipCalculatorModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Tip15 = model.CalculateTip(15);
                ViewBag.Tip20 = model.CalculateTip(20);
                ViewBag.Tip25 = model.CalculateTip(25);
            }
            else
            {
                ViewBag.Tip15 = 0;
                ViewBag.Tip20 = 0;
                ViewBag.Tip25 = 0;
            }
            return View(model);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
