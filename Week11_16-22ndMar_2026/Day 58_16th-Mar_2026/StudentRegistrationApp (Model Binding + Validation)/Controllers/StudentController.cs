using Microsoft.AspNetCore.Mvc;
using StudentRegistrationApp.Models;

namespace StudentRegistrationApp.Controllers
{
    public class StudentController : Controller
    {
        // Show Registration Form
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                student.Id = new Random().Next(1, 1000);

                TempData["SuccessMessage"] = "Student Registered Successfully!";

                return RedirectToAction("Details", new { id = student.Id });
            }

            return View(student);
        }

        public IActionResult Details(int id)
        {
            ViewBag.StudentId = id;
            return View();
        }
    }
}