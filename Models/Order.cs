using System.ComponentModel.DataAnnotations.Schema;

namespace OrderTrackingMVC.Models
{
    public class Order
    {
        public int OrderId { get; set; } // Primary Key

        [ForeignKey("User")]
        public int UserId { get; set; } // Foreign Key

        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string OrderStatus { get; set; } // "Pending", "Delivered", etc.

        // Navigation Properties
        public User User { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public Delivery Delivery { get; set; }

    }
}
