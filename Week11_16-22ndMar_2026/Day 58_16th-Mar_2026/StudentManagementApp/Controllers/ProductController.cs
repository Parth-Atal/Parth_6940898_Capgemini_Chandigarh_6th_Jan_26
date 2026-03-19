using Microsoft.AspNetCore.Mvc;
using StudentManagementApp.Filters;
using StudentManagementApp.Models;

namespace StudentManagementApp.Controllers
{
    [ServiceFilter(typeof(LogActionFilter))]
    public class ProductController : Controller
    {
        static List<Product> products = new List<Product>();

        public IActionResult Index()
        {
            // Test exception
            throw new Exception("Test Exception");

            return View(products);
        }

        public IActionResult Details(int id)
        {
            var p = products.FirstOrDefault(x => x.Id == id);
            return View(p);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product p)
        {
            p.Id = products.Count + 1;
            products.Add(p);
            return RedirectToAction("Index");
        }
    }
}