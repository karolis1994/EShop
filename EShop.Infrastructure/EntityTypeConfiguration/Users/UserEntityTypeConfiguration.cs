using EShop.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Infrastructure.EntityTypeConfiguration.Users
{
    internal class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User", EShopContext.DefaultSchema);

            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Username)
                .IsUnique();
            builder.HasIndex(e => e.Email)
                .IsUnique();

            builder.Property(e => e.Username)
                .HasMaxLength(30)
                .IsRequired();
            builder.Property(e => e.Email)
                .HasMaxLength(250)
                .IsRequired();

            builder.HasDiscriminator(e => e.Type)
                .HasValue<RegularUser>(UserType.Regular)
                .HasValue<AdministratorUser>(UserType.Administrator);
        }
    }
}
