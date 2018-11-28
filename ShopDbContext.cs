using Microsoft.EntityFrameworkCore;

namespace Test
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Shipment> Shipments { get; set; }

        public ShopDbContext(DbContextOptions<ShopDbContext> options)
            : base(options)
        {

        }
    }
}