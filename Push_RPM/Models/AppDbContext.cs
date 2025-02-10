using Microsoft.EntityFrameworkCore;

namespace Push_RPM.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Orders> CustomeOrdersrs { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Payments> Payments { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
