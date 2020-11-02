using EShop.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace EShop.Startup
{
    class Program
    {
        public static IConfigurationRoot configuration;

        static void Main(string[] args)
        {
            Console.WriteLine(".");
        }

        public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<EShopContext>
        {
            public EShopContext CreateDbContext(string[] args)
            {
                var configuration = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json")
                        .Build();

                var optionsBuilder = new DbContextOptionsBuilder<EShopContext>();

                var connectionString = configuration
                            .GetConnectionString("EShop");

                optionsBuilder.UseSqlServer(connectionString);

                return new EShopContext(optionsBuilder.Options);
            }
        }
    }
}
