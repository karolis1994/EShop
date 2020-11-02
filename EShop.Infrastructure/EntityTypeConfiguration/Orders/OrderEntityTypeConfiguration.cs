using EShop.Domain.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Infrastructure.EntityTypeConfiguration.Orders
{
    internal class OrderEntityTypeConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order", EShopContext.DefaultSchema);

            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.OrderByUser)
                .WithMany()
                .HasForeignKey(e => e.OrderByUserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
