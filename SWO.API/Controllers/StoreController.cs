using Microsoft.AspNetCore.Mvc;
using SWO.Shared.Classes.ViewModels;

namespace SWO.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : Controller
    {
        /*[HttpPost]
        public async Task<IActionResult> Post(SimulationViewModel simulation)
        {
            DateTime start = DateTime.Now;
            Thread.Sleep(127);
            DateTime end = DateTime.Now;
            return Ok((end - start).TotalMilliseconds);
        }*/
    }
}
