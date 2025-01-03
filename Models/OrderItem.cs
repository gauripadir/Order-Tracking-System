using System.ComponentModel.DataAnnotations.Schema;

namespace OrderTrackingMVC.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; } // Primary Key

        [ForeignKey("Order")]
        public int OrderId { get; set; } // Foreign Key

        [ForeignKey("FoodItem")]
        public int FoodId { get; set; } // Foreign Key

        public int Quantity { get; set; }
        public decimal Price { get; set; }

        // Navigation Properties
        public Order Order { get; set; }
        public FoodItem FoodItem { get; set; }

    }
}
