using Microsoft.AspNetCore.Mvc;

namespace NetCoreAreas_1Tekrar.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SimulationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
