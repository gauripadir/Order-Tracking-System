using Microsoft.EntityFrameworkCore;
using OrderTrackingMVC.Models;

namespace OrderTrackingMVC.Data
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define the primary key for FoodItem
            modelBuilder.Entity<FoodItem>()
                .HasKey(f => f.FoodId);
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }

    }

}
