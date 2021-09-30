using Microsoft.EntityFrameworkCore;
using DAL.Entities;
using DAL.Configurations;
using DAL.Entities.Order;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace DAL
{
    public class DrugstoreDBContext : IdentityDbContext
    {
        public DrugstoreDBContext(DbContextOptions<DrugstoreDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StoreConfig());
            modelBuilder.ApplyConfiguration(new OrderConfig());
            modelBuilder.Entity<OrderItem>()
                .HasOne(oI => oI.Order)
                .WithMany(o => o.OrderItems);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<RefreshToken> Tokens { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
