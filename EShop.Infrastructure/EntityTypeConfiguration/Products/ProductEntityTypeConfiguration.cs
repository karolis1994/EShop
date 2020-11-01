using EShop.Domain.Products;
using Innofactor.EfCoreJsonValueConverter;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Infrastructure.EntityTypeConfiguration.Products
{
    internal class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product", EShopContext.DefaultSchema);

            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Code)
                .IsUnique();

            builder.Property(e => e.Name)
                .HasMaxLength(250)
                .IsRequired();
            builder.Property(e => e.Code)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(e => e.Description)
                .HasJsonValueConversion();

            builder.HasOne(e => e.Category)
                .WithMany(e => e.Products)
                .HasForeignKey(e => e.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
