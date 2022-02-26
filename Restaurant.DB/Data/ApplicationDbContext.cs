using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Restaurant.ENTITY;

namespace Restaurant.DB.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<SubItem> SubItems { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<RawMaterials> RawMaterials { get; set; }
        public DbSet<PurchaseRM> PurchaseRMs { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<PurchaseDetails> PurchaseDetails { get; set; }
        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    }
}