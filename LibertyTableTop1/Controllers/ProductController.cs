using LibertyTableTop1.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibertyTableTop1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
        {
            new Product { Id = 1, Name = "Dining Table", Price = 500 },
            new Product { Id = 2, Name = "Coffee Table", Price = 300 },
            new Product { Id = 3, Name = "Office Desk", Price = 700 },
            new Product { Id = 4, Name = "Study Table", Price = 400 },
            new Product { Id = 5, Name = "Console Table", Price = 350 }
        };
            return View(products);
        }
    }
}
