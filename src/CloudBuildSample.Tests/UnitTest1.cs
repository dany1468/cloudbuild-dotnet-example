using System;
using System.Linq;
using CloudBuildSample.EF;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace CloudBuildSample.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var connectionString = Environment.GetEnvironmentVariable("CONN_STRING");

            var options = new DbContextOptionsBuilder<ProductsDbContext>().UseSqlServer(connectionString);
            using var context = new ProductsDbContext(options.Options);

            context.Database.ExecuteSqlRaw("DELETE FROM dbo.Products;");

            context.Products.Add(new Product()
            {
                ProductName = "Mac Book Pro",
                UnitPrice = 1000000
            });

            context.SaveChanges();

            var count = context.Products.Count();

            Assert.Equal(1, count);
        }
    }
}
