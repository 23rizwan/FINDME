using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;
namespace BulkyWeb.Controllers
{
    public class MainpageController : Controller
    {
        public IActionResult school()
        {
           return View();
        }
        private readonly ApplicationDbContext _context;

        public MainpageController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("school", "Mainpage"); // Redirect to home or any other page
            }
            return View(product);
        }
    }
}
