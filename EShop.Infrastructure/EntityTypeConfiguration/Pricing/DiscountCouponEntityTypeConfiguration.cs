using EShop.Domain.Pricing;
using Innofactor.EfCoreJsonValueConverter;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Infrastructure.EntityTypeConfiguration.Pricing
{
    internal class DiscountCouponEntityTypeConfiguration : IEntityTypeConfiguration<DiscountCoupon>
    {
        public void Configure(EntityTypeBuilder<DiscountCoupon> builder)
        {
            builder.ToTable("DiscountCoupon", EShopContext.DefaultSchema);

            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Code)
                .IsUnique();

            builder.Property(e => e.Name)
                .HasJsonValueConversion();
            builder.Property(e => e.Code)
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}
