using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace OrderTrackingMVC.Models
{
    public class User
    {
        public int UserId { get; set; } // Primary Key
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // "Customer" or "Admin"
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedDate { get; set; }

        // Navigation Properties
        public ICollection<Order> Orders { get; set; }
        //public ICollection<Cart> Carts { get; set; }
        //public ICollection<Complaint> Complaints { get; set; }
        //public ICollection<CateringOrder> CateringOrders { get; set; }
        //public ICollection<Notification> Notifications { get; set; }
        //public ICollection<Review> Reviews { get; set; }

    }
}
