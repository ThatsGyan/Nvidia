using Microsoft.AspNetCore.Mvc;

namespace Nvidia.Controllers
{
    public class Ecommerce : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Product()
        {
            return View();
        }
    }
}
