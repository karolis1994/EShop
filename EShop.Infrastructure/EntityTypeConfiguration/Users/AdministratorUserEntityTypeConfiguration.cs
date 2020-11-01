using EShop.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Infrastructure.EntityTypeConfiguration.Users
{
    internal class AdministratorUserEntityTypeConfiguration : IEntityTypeConfiguration<AdministratorUser>
    {
        public void Configure(EntityTypeBuilder<AdministratorUser> builder)
        {
            builder.HasBaseType(typeof(User));
        }
    }
}
