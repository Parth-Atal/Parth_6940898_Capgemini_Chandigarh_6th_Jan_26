using EcommerceApp.Data;
using EcommerceApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Authorize(Roles = "Admin")]
public class CustomerController : Controller
{
    private readonly AppDbContext _context;

    public CustomerController(AppDbContext context)
    {
        _context = context;
    }

    // GET: Customers
    public async Task<IActionResult> Index()
    {
        return View(await _context.Customers.ToListAsync());
    }

    // GET: Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Create
    [HttpPost]
    public async Task<IActionResult> Create(Customer customer)
    {
        if (ModelState.IsValid)
        {
            _context.Add(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        return View(customer);
    }

    // GET: Order History
    public async Task<IActionResult> OrderHistory(int id)
    {
        var customer = await _context.Customers
            .Include(c => c.Orders)
                .ThenInclude(o => o.OrderItems)
                    .ThenInclude(oi => oi.Product)
            .Include(c => c.Orders)
                .ThenInclude(o => o.ShippingDetail)
            .FirstOrDefaultAsync(c => c.CustomerId == id);

        return View(customer);
    }

    // GET: Edit
    public async Task<IActionResult> Edit(int id)
    {
        var customer = await _context.Customers.FindAsync(id);
        return View(customer);
    }

    // POST: Edit
    [HttpPost]
    public async Task<IActionResult> Edit(Customer customer)
    {
        _context.Update(customer);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    // GET: Delete
    public async Task<IActionResult> Delete(int id)
    {
        var customer = await _context.Customers.FindAsync(id);
        return View(customer);
    }

    // POST: Delete
    [HttpPost]
    public async Task<IActionResult> Delete(Customer customer)
    {
        _context.Customers.Remove(customer);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
}