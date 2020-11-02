using EShop.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Infrastructure.EntityTypeConfiguration.Suppliers
{
    internal class SupplierProductEntityTypeConfiguration : IEntityTypeConfiguration<SupplierProduct>
    {
        public void Configure(EntityTypeBuilder<SupplierProduct> builder)
        {
            builder.ToTable("SupplierProduct", EShopContext.DefaultSchema);

            builder.HasKey(e => new { e.ProductId, e.SupplierId });

            builder.HasOne(e => e.Product)
                .WithMany(e => e.Suppliers)
                .HasForeignKey(e => e.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Supplier)
                .WithMany(e => e.Products)
                .HasForeignKey(e => e.SupplierId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
