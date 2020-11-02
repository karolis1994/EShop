using EShop.Domain.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Infrastructure.EntityTypeConfiguration.Orders
{
    internal class OrderBillingInformationEntityTypeConfiguration : IEntityTypeConfiguration<OrderBillingInformation>
    {
        public void Configure(EntityTypeBuilder<OrderBillingInformation> builder)
        {
            builder.ToTable("OrderBillingInformation", EShopContext.DefaultSchema);

            builder.HasKey(e => e.Id);

            builder.Property(e => e.City)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(e => e.Street)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(e => e.HouseNumber)
                .HasMaxLength(10)
                .IsRequired();
            builder.Property(e => e.FlatNumber)
                .HasMaxLength(10);
            builder.Property(e => e.ZipCode)
                .HasMaxLength(20)
                .IsRequired();

            builder.HasOne(e => e.Country)
                .WithMany()
                .HasForeignKey(e => e.CountryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
