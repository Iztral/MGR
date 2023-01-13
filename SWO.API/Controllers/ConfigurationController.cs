using Microsoft.AspNetCore.Mvc;

namespace SWO.API.Controllers
{
    public class ConfigurationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
