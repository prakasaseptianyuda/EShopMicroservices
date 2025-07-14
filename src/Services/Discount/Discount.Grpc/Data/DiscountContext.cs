using Discount.Grpc.Models;
using Microsoft.EntityFrameworkCore;

namespace Discount.Grpc.Data
{
    public class DiscountContext : DbContext
    {
        public DbSet<Coupon> Coupon { get; set; }

        public DiscountContext(DbContextOptions<DiscountContext> options) : base(options)
        {          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coupon>().HasData(
                    new Coupon { 
                        Id=1,
                        ProductName = "IPhone X", 
                        Description = "IPhone Discount",
                        Ammount = 150
                    },
                    new Coupon
                    {
                        Id = 2,
                        ProductName = "Samsung 10",
                        Description = "Samsung Discount",
                        Ammount = 100
                    }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
