using Microsoft.AspNetCore.Mvc;

namespace SWO.Portal.Controllers.Admin
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LocationIndex() 
        { 
            return View(); 
        }

        public IActionResult ScenarioIndex()
        {
            return View();
        }

        public IActionResult SimulationIndex()
        {
            return View();
        }

        public IActionResult SimulatorIndex()
        {
            return View();
        }

        public IActionResult MemberIndex()
        {
            return View();
        }
    }
}
