using EShop.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Infrastructure.EntityTypeConfiguration.Users
{
    internal class RegularUserEntityTypeConfiguration : IEntityTypeConfiguration<RegularUser>
    {
        public void Configure(EntityTypeBuilder<RegularUser> builder)
        {
            builder.HasBaseType(typeof(User));

            builder.Property(e => e.Name)
                .HasMaxLength(30)
                .IsRequired();
            builder.Property(e => e.Surname)
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}
