using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;
using TamagotchiPokemonWeb.Models;
using TamagotchiPokemonWeb.Services;

namespace TamagotchiPokemonWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StartGame(Player player)
        {
            ViewData["Player"] = "teste";
            Console.WriteLine("teste");
            return  RedirectToAction("MenuPrincipal","Game");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
