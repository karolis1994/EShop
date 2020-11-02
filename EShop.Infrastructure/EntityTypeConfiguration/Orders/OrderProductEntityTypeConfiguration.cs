using EShop.Domain.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Infrastructure.EntityTypeConfiguration.Orders
{
    internal class OrderProductEntityTypeConfiguration : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            builder.ToTable("OrderProduct", EShopContext.DefaultSchema);

            builder.HasKey(e => new { e.OrderId, e.ProductId, e.SupplierId });

            builder.HasOne(e => e.Order)
                .WithMany(e => e.Products)
                .HasForeignKey(e => e.OrderId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(e => e.Product)
                .WithMany()
                .HasForeignKey(e => e.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Supplier)
                .WithMany()
                .HasForeignKey(e => e.SupplierId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.ProductPrice)
                .WithMany()
                .HasForeignKey(e => e.ProductPriceId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
