using Microsoft.AspNetCore.Mvc;
using LibraryManagementMVC.Models;
using LibraryManagementMVC.ViewModels;

namespace LibraryManagementMVC.Controllers
{
    public class BooksController : Controller
    {
        // Temporary in-memory list (acts like DB)
        private static List<BookViewModel> books = new List<BookViewModel>()
        {
            new BookViewModel
            {
                Book = new Book { Id = 1, Title = "1984", Author = "George Orwell", PublishedYear = 1949, Genre = "Dystopian" },
                IsAvailable = true,
                BorrowerName = ""
            },
            new BookViewModel
            {
                Book = new Book { Id = 2, Title = "Harry Potter", Author = "J.K. Rowling", PublishedYear = 1997, Genre = "Fantasy" },
                IsAvailable = false,
                BorrowerName = "John"
            }
        };

        // 📌 INDEX
        public IActionResult Index()
        {
            ViewBag.Message = "Welcome to Library";
            ViewData["TotalBooks"] = books.Count;

            return View(books);
        }

        // 📌 CREATE (GET)
        public IActionResult Create()
        {
            return View();
        }

        // 📌 CREATE (POST)
        [HttpPost]
        public IActionResult Create(BookViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.Book.Id = books.Count + 1;
                books.Add(model);

                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}