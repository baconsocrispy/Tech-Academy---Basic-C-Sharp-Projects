using Microsoft.AspNetCore.Mvc;

namespace CoreTourVideo.Controllers
{
    public class Products : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
