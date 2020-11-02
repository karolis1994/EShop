using EShop.Domain.Images;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Infrastructure.EntityTypeConfiguration.Images
{
    internal class ImageEntityTypeConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.ToTable("Image", EShopContext.DefaultSchema);

            builder.HasKey(e => e.Id);

            builder.Property(e => e.ImageName)
                .HasMaxLength(250)
                .IsRequired();
        }
    }
}
