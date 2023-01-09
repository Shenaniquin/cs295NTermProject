using Microsoft.AspNetCore.Mvc;

namespace OregonAnimals.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Concentration()
        {
            return View();
        }
    }
}
