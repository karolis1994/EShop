using EShop.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Infrastructure.EntityTypeConfiguration.Products
{
    internal class ProductCategoryDiscountEntityTypeConfiguration : IEntityTypeConfiguration<ProductCategoryDiscount>
    {
        public void Configure(EntityTypeBuilder<ProductCategoryDiscount> builder)
        {
            builder.ToTable("ProductCategoryDiscount", EShopContext.DefaultSchema);

            builder.HasKey(e => new { e.EntityId, e.DiscountId });

            builder.HasOne(e => e.Entity)
                .WithMany(e => e.Discounts)
                .HasForeignKey(e => e.EntityId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
