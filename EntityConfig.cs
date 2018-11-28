using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Test
{
    class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // You dont need to specify Primary Key
            // as it will be extracted from class using convention
            
            builder
                .HasOne(p => p.DefaultAddress)
                .WithMany()
                .IsRequired(false);

            builder
                .HasOne(p => p.BillingAddress)
                .WithMany()
                .IsRequired(false);
        }
    }

    class ShipmentConfig : IEntityTypeConfiguration<Shipment>
    {
        public void Configure(EntityTypeBuilder<Shipment> builder)
        {
            builder
                .HasOne(p => p.DeliveryAddress)
                .WithMany()
                .IsRequired(false);
        }
    }
}