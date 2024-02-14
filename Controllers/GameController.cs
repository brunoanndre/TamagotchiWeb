using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Xml.Linq;
using Tamagotchi.Service;
using TamagotchiPokemonWeb.Models;

namespace TamagotchiPokemonWeb.Services
{
    public class GameController : Controller
    {
        private GameService _gameService;
        private IEnumerable<TamagotchiDTO> mascotes { get; set; } = new List<TamagotchiDTO>();


        public GameController(GameService gameService)
        {
            _gameService = gameService;
        }

        public IActionResult InteragirMascote()
        {
            return View(_gameService.AdoptedsTamagotchis);
        }
        public IActionResult MenuPrincipal(string name)
        {
            _gameService.FindAllSpecies();
            ViewData["Player"] = name;
            return View();
        }

        public IActionResult MenuInteracao(int id)
        {
            return View(_gameService.AdoptedsTamagotchis.Find(tmg => tmg.Id == id));
        }

        public IActionResult AdotarMascote()
        {
            var TamagotchiResults = _gameService._tamagotchiDetailsResult;

            return View(TamagotchiResults);
        }

        [HttpPost]
        public IActionResult AdotarMascote(string name)
        { 
            _gameService.AdoptTamagotchi(name);

            return RedirectToAction("MenuPrincipal");
        }

        [HttpGet]
        public IActionResult MascoteInfos(string name)
        {
            var Tamagotchi = _gameService.FindSpecieDetail(name);
            return View(Tamagotchi);
        }

        [HttpGet]
        public IActionResult MascotesAdotados()
        {
            return View(_gameService.AdoptedsTamagotchis);
        }

        [HttpPost]
        public IActionResult AlimentarTamagotchi(int id)
        {
            TamagotchiDTO tamagotchi = _gameService.FindById(id);
            _gameService.FeedTamagotchi(tamagotchi);
            return RedirectToAction("MenuInteracao",tamagotchi);
        }

        [HttpPost]
        public IActionResult RestTamagotchi(int id)
        {
            TamagotchiDTO tamagotchi = _gameService.FindById(id);
            _gameService.PetTamagotchi(tamagotchi);
            return RedirectToAction("MenuInteracao", tamagotchi);
        }

        public IActionResult PlayWithTamagotchi(int id)
        {
            TamagotchiDTO tamagotchi = _gameService.FindById(id);
            _gameService.PlayWithTamagotchi(tamagotchi);
            return RedirectToAction("MenuInteracao", tamagotchi);
        }

        public IActionResult PetTamagotchi(int id)
        {
            TamagotchiDTO tamagotchi = _gameService.FindById(id);
            _gameService.PetTamagotchi(tamagotchi);
            return RedirectToAction("MenuInteracao", tamagotchi);
        }
    }
}
