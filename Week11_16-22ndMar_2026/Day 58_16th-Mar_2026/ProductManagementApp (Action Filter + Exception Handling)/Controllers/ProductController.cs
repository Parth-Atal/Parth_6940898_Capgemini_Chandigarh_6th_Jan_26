using Microsoft.AspNetCore.Mvc;
using ProductManagementApp.Filters;
using System;
using System.Collections.Generic;

namespace ProductManagementApp.Controllers
{
    [ServiceFilter(typeof(LogActionFilter))]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            
            throw new Exception("Test exception triggered!");

            
            var products = new List<string>
            {
                "Laptop",
                "Phone",
                "Tablet"
            };

            return View(products);
        }
    }
}