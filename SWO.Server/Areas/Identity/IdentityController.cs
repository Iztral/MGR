using Microsoft.AspNetCore.Mvc;

namespace SWO.Portal.Areas.Identity
{
    public class IdentityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
