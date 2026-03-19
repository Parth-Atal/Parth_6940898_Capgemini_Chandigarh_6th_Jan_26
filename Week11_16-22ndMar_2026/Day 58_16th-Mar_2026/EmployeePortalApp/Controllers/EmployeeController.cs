using Microsoft.AspNetCore.Mvc;
using EmployeePortalApp.Models;

namespace EmployeePortalApp.Controllers
{
    public class EmployeeController : Controller
    {
        public static List<Employee> employees = new List<Employee>();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Employee emp)
        {
            if (ModelState.IsValid)
            {
                emp.Id = employees.Count + 1;
                employees.Add(emp);

                TempData["Success"] = "Employee Registered Successfully!";

                return RedirectToAction("Details", new { id = emp.Id });
            }

            return View(emp);
        }

        public IActionResult Details(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            return View(emp);
        }
    }
}