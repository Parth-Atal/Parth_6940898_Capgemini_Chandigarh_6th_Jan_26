using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LibraryManagement.Models;

namespace LibraryManagement.Controllers
{
    public class BookBorrowersController : Controller
    {
        private readonly LibraryDbContext _context;

        public BookBorrowersController(LibraryDbContext context)
        {
            _context = context;
        }

        // GET: BookBorrowers
        public async Task<IActionResult> Index()
        {
            var data = _context.BookBorrowers
                .Include(b => b.Book)
                .Include(b => b.Borrower);

            return View(await data.ToListAsync());
        }

        // GET: BookBorrowers/Details
        public async Task<IActionResult> Details(int? bookId, int? borrowerId)
        {
            if (bookId == null || borrowerId == null)
            {
                return NotFound();
            }

            var bookBorrower = await _context.BookBorrowers
                .Include(b => b.Book)
                .Include(b => b.Borrower)
                .FirstOrDefaultAsync(m => m.BookId == bookId && m.BorrowerId == borrowerId);

            if (bookBorrower == null)
            {
                return NotFound();
            }

            return View(bookBorrower);
        }

        // GET: BookBorrowers/Create
        public IActionResult Create()
        {
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "Title");
            ViewData["BorrowerId"] = new SelectList(_context.Borrowers, "BorrowerId", "FullName");
            return View();
        }

        // POST: BookBorrowers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookId,BorrowerId,BorrowDate")] BookBorrower bookBorrower)
        {
            // Remove navigation property validation errors
            ModelState.Remove("Book");
            ModelState.Remove("Borrower");

            if (ModelState.IsValid)
            {
                try
                {
                    _context.BookBorrowers.Add(bookBorrower);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException ex)
                {
                    ModelState.AddModelError("", "Unable to save record. This book may already be borrowed by this borrower.");
                    Console.WriteLine("Database Error: " + ex.InnerException?.Message);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "An unexpected error occurred while saving the record.");
                    Console.WriteLine("General Error: " + ex.Message);
                }
            }

            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "Title", bookBorrower.BookId);
            ViewData["BorrowerId"] = new SelectList(_context.Borrowers, "BorrowerId", "FullName", bookBorrower.BorrowerId);

            return View(bookBorrower);
        }

        // GET: BookBorrowers/Edit
        public async Task<IActionResult> Edit(int? bookId, int? borrowerId)
        {
            if (bookId == null || borrowerId == null)
            {
                return NotFound();
            }

            var bookBorrower = await _context.BookBorrowers
                .FirstOrDefaultAsync(x => x.BookId == bookId && x.BorrowerId == borrowerId);

            if (bookBorrower == null)
            {
                return NotFound();
            }

            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "Title", bookBorrower.BookId);
            ViewData["BorrowerId"] = new SelectList(_context.Borrowers, "BorrowerId", "FullName", bookBorrower.BorrowerId);

            return View(bookBorrower);
        }

        // POST: BookBorrowers/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int bookId, int borrowerId, [Bind("BookId,BorrowerId,BorrowDate")] BookBorrower bookBorrower)
        {
            if (bookId != bookBorrower.BookId || borrowerId != bookBorrower.BorrowerId)
            {
                return NotFound();
            }

            ModelState.Remove("Book");
            ModelState.Remove("Borrower");

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookBorrower);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookBorrowerExists(bookBorrower.BookId, bookBorrower.BorrowerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "Title", bookBorrower.BookId);
            ViewData["BorrowerId"] = new SelectList(_context.Borrowers, "BorrowerId", "FullName", bookBorrower.BorrowerId);

            return View(bookBorrower);
        }

        // GET: BookBorrowers/Delete
        public async Task<IActionResult> Delete(int? bookId, int? borrowerId)
        {
            if (bookId == null || borrowerId == null)
            {
                return NotFound();
            }

            var bookBorrower = await _context.BookBorrowers
                .Include(b => b.Book)
                .Include(b => b.Borrower)
                .FirstOrDefaultAsync(m => m.BookId == bookId && m.BorrowerId == borrowerId);

            if (bookBorrower == null)
            {
                return NotFound();
            }

            return View(bookBorrower);
        }

        // POST: BookBorrowers/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int bookId, int borrowerId)
        {
            var bookBorrower = await _context.BookBorrowers
                .FirstOrDefaultAsync(x => x.BookId == bookId && x.BorrowerId == borrowerId);

            if (bookBorrower != null)
            {
                _context.BookBorrowers.Remove(bookBorrower);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        private bool BookBorrowerExists(int bookId, int borrowerId)
        {
            return _context.BookBorrowers.Any(e => e.BookId == bookId && e.BorrowerId == borrowerId);
        }
    }
}