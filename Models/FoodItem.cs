using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace OrderTrackingMVC.Models
{
    public class FoodItem
    {
        public int FoodId { get; set; } // Primary Key
        public string FoodName { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        // Navigation Properties
       // public ICollection<Cart> Carts { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
       // public ICollection<Review> Reviews { get; set; }

    }
}
