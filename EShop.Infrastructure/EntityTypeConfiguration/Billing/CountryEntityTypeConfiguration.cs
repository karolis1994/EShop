using EShop.Domain.Billing;
using Innofactor.EfCoreJsonValueConverter;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Infrastructure.EntityTypeConfiguration.Billing
{
    internal class CountryEntityTypeConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Country", EShopContext.DefaultSchema);

            builder.HasKey(e => e.Id);

            builder.Property(e => e.ISOCode)
                .HasMaxLength(3)
                .IsRequired();

            builder.Property(e => e.Name)
                .HasJsonValueConversion();
        }
    }
}
