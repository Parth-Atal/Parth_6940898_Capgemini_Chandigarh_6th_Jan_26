using Microsoft.AspNetCore.Mvc;

namespace SessionLoginApp.Controllers
{
    public class AccountController : Controller
    {
        // Show Login Page
        public IActionResult Login()
        {
            return View();
        }

        // Handle Login POST
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "Parth" && password == "1234")
            {
                
                HttpContext.Session.SetString("Username", username);

                return RedirectToAction("Dashboard");
            }

            ViewBag.Error = "Invalid Username or Password";
            return View();
        }

        // Dashboard
        public IActionResult Dashboard()
        {
            var user = HttpContext.Session.GetString("Username");

            
            if (user == null)
            {
                return RedirectToAction("Login");
            }

            ViewBag.Username = user;
            return View();
        }

        // Logout
        public IActionResult Logout()
        {
           
            HttpContext.Session.Clear();

            return RedirectToAction("Login");
        }
    }
}