using Microsoft.AspNetCore.Mvc;
using OregonAnimals.Data;
using OregonAnimals.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
namespace OregonAnimals.Controllers
{
    public class AnimalsController : Controller
    {
        IAnimalsRepository repo;
        public AnimalsController(IAnimalsRepository a)
        {
            repo = a;
        }
        public IActionResult Animals(string displayAnimal, string userName)
        {
            const string DEFAULTANIMAL = "Beaver";
            List<SightingModel> sighting;
            List<AnimalModel> animal;
            if (displayAnimal != null && userName == null)
            {
                animal = (
                    from a in repo.Animals
                    where a.Animal == displayAnimal
                    select a
                ).ToList<AnimalModel>();
                sighting = (
                    from a in repo.Sightings
                    where a.AnimalSighted.Animal == displayAnimal
                    select a
                ).ToList<SightingModel>();
            }
            else if (userName != null)
            {
                /*animal = (
                    from a in repo.Animals
                    where a.Animal == DEFAULTANIMAL
                    select a
                ).ToList<AnimalModel>();*/
                sighting = (
                    from a in repo.Sightings
                    where a.UserName == userName
                    select a
                ).ToList<SightingModel>();
            }
            else {
                animal = (
                    from a in repo.Animals
                    where a.Animal == DEFAULTANIMAL
                    select a
                ).ToList<AnimalModel>();
                sighting = (
                    from a in repo.Sightings
                    where a.AnimalSighted.Animal == DEFAULTANIMAL
                    select a
                ).ToList<SightingModel>();
            }
            return View(sighting);
        }
        [HttpPost]
        public IActionResult AddSighting(SightingModel model)
        {
            if (0 < repo.StoreSighting(model))
            {
                return RedirectToAction("Animals", new { sightingID = model.SightingID });
            }
            else { return View(); }
        }
        public IActionResult Index()
        {
            return View("Animals");
        }
    }
}
