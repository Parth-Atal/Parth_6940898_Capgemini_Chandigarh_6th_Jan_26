using Microsoft.AspNetCore.Mvc;
using StudentManagementApp.Models;

namespace StudentManagementApp.Controllers
{
    public class StudentController : Controller
    {
        public static List<Student> students = new List<Student>();

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Student s)
        {
            if (ModelState.IsValid)
            {
                s.Id = students.Count + 1;
                students.Add(s);

                TempData["Success"] = "Student Registered Successfully!";

                return RedirectToAction("Details", new { id = s.Id });
            }

            return View(s);
        }

        public IActionResult Details(int id)
        {
            var student = students.FirstOrDefault(x => x.Id == id);
            return View(student);
        }
    }
}