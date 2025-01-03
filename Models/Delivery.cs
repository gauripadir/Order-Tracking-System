using System.ComponentModel.DataAnnotations.Schema;

namespace OrderTrackingMVC.Models
{
    public class Delivery
    {
        public int DeliveryId { get; set; } // Primary Key

        [ForeignKey("Order")]
        public int OrderId { get; set; } // Foreign Key

        public string DeliveryStatus { get; set; } // "Out for Delivery", "Delivered"
        public DateTime? DeliveryDate { get; set; }
        public string DeliveryPerson { get; set; }

        // Navigation Properties
        public Order Order { get; set; }
    }
}

