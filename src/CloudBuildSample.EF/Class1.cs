using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CloudBuildSample.EF
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }

    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }

    public class ProductsDbContextFactory : IDesignTimeDbContextFactory<ProductsDbContext>
    {
        public ProductsDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ProductsDbContext>();
            var connectionString = Environment.GetEnvironmentVariable("CONN_STRING");
            optionsBuilder.UseSqlServer(connectionString, b => b.MigrationsAssembly("CloudBuildSample.EF"));
            return new ProductsDbContext(optionsBuilder.Options);
        }
    }
}
