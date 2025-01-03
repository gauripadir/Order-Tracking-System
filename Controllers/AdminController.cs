using Microsoft.AspNetCore.Mvc;
using OrderTrackingMVC.Data;
using Microsoft.EntityFrameworkCore;

namespace OrderTrackingMVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public AdminController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Displays all customer orders for admin
        public IActionResult AllOrders()
        {
            var orders = _dbContext.Orders.Include(o => o.User).ToList();
            return View(orders);
        }

        // Updates the status of a specific order
       
        [HttpPost]
        public IActionResult UpdateOrderStatus(int id, string status)
        {
            try
            {
                // Find the order in the database
                var order = _dbContext.Orders.FirstOrDefault(o => o.OrderId == id);
                if (order == null)
                {
                    TempData["Error"] = "Order not found.";
                    return RedirectToAction("AllOrders");
                }

                // Update the order status
                order.OrderStatus = status;

                // Save changes to the database
                _dbContext.SaveChanges();

                // Set a success message
                TempData["Success"] = "Order status updated successfully!";
            }
            catch (Exception ex)
            {
                TempData["Error"] = $"An error occurred: {ex.Message}";
            }

            // Redirect back to the AllOrders view
            return RedirectToAction("AllOrders");
        }



    }
}
