using Microsoft.AspNetCore.Mvc;
using MVCSolution.Models;

namespace MVCSolution.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 1200 },
                new Product { Id = 2, Name = "Smartphone", Price = 800 }
            };
            return View(products); // Ensure data is passed to the view
        }
    }
}
