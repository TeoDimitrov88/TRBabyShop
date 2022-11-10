using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TRBabyShop.Infrastructure.Data.Configuration;
using TRBabyShop.Infrastructure.Data.Models;

namespace TRBabyShop.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<Order> Orders { get; set; } = null!;

        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Review> Reviews { get; set; } = null!;

        public DbSet<UserProduct> UserProducts { get; set; } = null!;

        public DbSet<ShoppingCart> ShoppingCarts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());

            builder.Entity<UserProduct>()
                .HasKey(u => new { u.UserId, u.ProductId });

            base.OnModelCreating(builder);
        }
    }
}