using EcommerceApp.Data;
using EcommerceApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


[Authorize(Roles = "User")]
public class OrderController : Controller
{
    private readonly AppDbContext _context;

    public OrderController(AppDbContext context)
    {
        _context = context;
    }

    // GET: Create Order
    public async Task<IActionResult> Create()
    {
        ViewBag.Customers = await _context.Customers.ToListAsync();
        ViewBag.Products = await _context.Products.ToListAsync();

        return View();
    }

    // POST: Create Order
    [HttpPost]
    public async Task<IActionResult> Create(int customerId, List<int> productIds, List<int> quantities, string address)
    {
        var order = new Order
        {
            CustomerId = customerId,
            OrderDate = DateTime.Now
        };

        _context.Orders.Add(order);
        await _context.SaveChangesAsync();

        // Add OrderItems
        for (int i = 0; i < productIds.Count; i++)
        {
            var item = new OrderItem
            {
                OrderId = order.OrderId,
                ProductId = productIds[i],
                Quantity = quantities[i]
            };

            _context.OrderItems.Add(item);
        }

        // Shipping
        var shipping = new ShippingDetail
        {
            OrderId = order.OrderId,
            Address = address,
            Status = "Pending"
        };

        _context.ShippingDetails.Add(shipping);

        await _context.SaveChangesAsync();

        return RedirectToAction("Details", new { id = order.OrderId });
    }

    // Order Details
    public async Task<IActionResult> Details(int id)
    {
        var order = await _context.Orders
            .Include(o => o.Customer)
            .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
            .Include(o => o.ShippingDetail)
            .FirstOrDefaultAsync(o => o.OrderId == id);

        return View(order);
    }
}