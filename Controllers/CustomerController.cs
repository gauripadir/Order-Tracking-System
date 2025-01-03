using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderTrackingMVC.Data;

namespace OrderTrackingMVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CustomerController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Displays the list of orders for the logged-in customer
        public IActionResult MyOrders()
        {
            //var userId = GetLoggedInUserId();
            var userId = 2;   //hardcoded 
            var orders = _dbContext.Orders
                .Where(o => o.UserId == userId)
                .Include(o => o.OrderItems)
                .ToList();
            return View(orders);
        }
        public IActionResult TrackOrder(int id)
        {
            //var userId = GetLoggedInUserId();
            var userId = 2;  //hardcoded
            var order = _dbContext.Orders.Include(o => o.OrderItems).FirstOrDefault(o => o.OrderId == id && o.UserId == userId);
            
            if (order == null)
                return NotFound();

            return View(order);
        }
        //private int GetLoggedInUserId()
        //{
        //    // Replace this with your actual authentication logic to get the logged-in user's ID
        //    return int.Parse(User.FindFirst("UserId").Value);
        //}

    }
}
