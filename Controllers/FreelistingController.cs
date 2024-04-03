using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class FreelistingController : Controller
    {
        public IActionResult AddProduct()
        {
            return View();
        }
    }
}
