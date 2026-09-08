using Microsoft.EntityFrameworkCore;
using TechGearStore.Models;

namespace TechGearStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Mechanical Gaming Keyboard", Description = "RGB Backlit Tactile Switches", Price = 89.99m, Category = "Peripherals", ImageUrl = "/images/keyboard.jpg", IsFeatured = true },
                new Product { Id = 2, Name = "Ergonomic Wireless Mouse", Description = "High Precision Optical Sensor", Price = 49.99m, Category = "Peripherals", ImageUrl = "/images/mouse.jpg", IsFeatured = true },
                new Product { Id = 3, Name = "UltraWide 34-inch Monitor", Description = "144Hz 4K Curved Display", Price = 499.99m, Category = "Monitors", ImageUrl = "/images/monitor.jpg", IsFeatured = false }
            );
        }
    }
}