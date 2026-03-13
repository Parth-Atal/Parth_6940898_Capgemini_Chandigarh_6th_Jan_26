using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UniversityMS.Data;
using UniversityMS.Models;

namespace UniversityMS.Controllers
{
    public class InstructorsController : Controller
    {
        private readonly UniversityContext _context;

        public InstructorsController(UniversityContext context)
        {
            _context = context;
        }

        // GET: Instructors
        public async Task<IActionResult> Index()
        {
            var instructors = await _context.Instructors
                .Include(i => i.Department)
                .Include(i => i.Courses)
                .ToListAsync();
            return View(instructors);
        }
        // GET: Instructors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var instructor = await _context.Instructors
                .Include(i => i.Department)
                .Include(i => i.Courses)
                .FirstOrDefaultAsync(i => i.InstructorId == id);

            if (instructor == null) return NotFound();
            return View(instructor);
        }

        // GET: Instructors/Create
        public IActionResult Create()
        {
            ViewData["DepartmentId"] = new SelectList(
                _context.Departments, "DepartmentId", "Name");
            return View();
        }

        // POST: Instructors/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
    [Bind("Name,DepartmentId")] Instructor instructor)
        {
            ModelState.Remove("Department");
            ModelState.Remove("Courses");

            if (ModelState.IsValid)
            {
                _context.Instructors.Add(instructor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentId"] = new SelectList(
                _context.Departments, "DepartmentId", "Name", instructor.DepartmentId);
            return View(instructor);
        }

        // GET: Instructors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var instructor = await _context.Instructors.FindAsync(id);
            if (instructor == null) return NotFound();
            ViewData["DepartmentId"] = new SelectList(
                _context.Departments, "DepartmentId", "Name", instructor.DepartmentId);
            return View(instructor);
        }

        // POST: Instructors/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,
            [Bind("InstructorId,Name,DepartmentId")] Instructor instructor)
        {
            if (id != instructor.InstructorId) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(instructor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Instructors.Any(i => i.InstructorId == id))
                        return NotFound();
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentId"] = new SelectList(
                _context.Departments, "DepartmentId", "Name", instructor.DepartmentId);
            return View(instructor);
        }

        // GET: Instructors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var instructor = await _context.Instructors
                .Include(i => i.Department)
                .FirstOrDefaultAsync(i => i.InstructorId == id);
            if (instructor == null) return NotFound();
            return View(instructor);
        }

        // POST: Instructors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var instructor = await _context.Instructors.FindAsync(id);
            if (instructor != null)
            {
                _context.Instructors.Remove(instructor);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}