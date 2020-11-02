using EShop.Domain.Products;
using EShop.Infrastructure.EntityTypeConfiguration.Billing;
using EShop.Infrastructure.EntityTypeConfiguration.Images;
using EShop.Infrastructure.EntityTypeConfiguration.Pricing;
using EShop.Infrastructure.EntityTypeConfiguration.Products;
using EShop.Infrastructure.EntityTypeConfiguration.Suppliers;
using EShop.Infrastructure.EntityTypeConfiguration.Users;
using Microsoft.EntityFrameworkCore;

namespace EShop.Infrastructure
{
    public class EShopContext : DbContext
    {
        public const string DefaultSchema = "EShop";

        public EShopContext(DbContextOptions<EShopContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Images
            modelBuilder.ApplyConfiguration(new ImageEntityTypeConfiguration());

            //Products
            modelBuilder.ApplyConfiguration(new ProductCategoryEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductImageEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductPriceEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductDiscountEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoryDiscountEntityTypeConfiguration());

            //Users
            modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RegularUserEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new AdministratorUserEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RegularUserBillingInformationEntityTypeConfiguration());

            //Billing
            modelBuilder.ApplyConfiguration(new CountryEntityTypeConfiguration());

            //Pricing
            modelBuilder.ApplyConfiguration(new DiscountEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DiscountCouponEntityTypeConfiguration());

            //Suppliers
            modelBuilder.ApplyConfiguration(new SupplierEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierProductEntityTypeConfiguration());
        }
    }
}
