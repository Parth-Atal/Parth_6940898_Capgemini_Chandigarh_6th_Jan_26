using Microsoft.AspNetCore.Mvc;
using EmployeePortalApp.Filters;
using EmployeePortalApp.Models;

namespace EmployeePortalApp.Controllers
{
    [ServiceFilter(typeof(LogActionFilter))]
    public class HRController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EmployeeList()
        {
            return View(EmployeeController.employees);
        }

        public IActionResult Reports()
        {
            // Test exception
            throw new Exception("Report error!");
        }
    }
}