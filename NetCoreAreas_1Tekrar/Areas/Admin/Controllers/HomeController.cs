using Microsoft.AspNetCore.Mvc;

namespace NetCoreAreas_1Tekrar.Areas.Admin.Controllers
{
    // Area'lar Attribute olarak tanımlanmadan çalışmaz 


    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
