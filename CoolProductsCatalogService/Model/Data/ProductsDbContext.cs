using CoolProductsCatalogService.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoolProductsCatalogService.Model.Data
{
    public class ProductsDbContext : DbContext
    {
        // configure db by ctor
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options)
        {

        }


        // configure tables
        public DbSet<Product> Products { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            var products = new List<Product>()
            {
                new Product { Id = 1,Brand="Apple", Category="Mobiles", Country="India", InStock=true, Name="IPhone 15", Price=79999},
                 new Product { Id = 2,Brand="Samsung", Category="Mobiles", Country="India", InStock=true, Name="Galaxy S24", Price=89999},
                  new Product { Id = 3,Brand="Apple", Category="Mobiles", Country="India", InStock=true, Name="IPhone 15 pro", Price=99999},
                   new Product { Id = 4,Brand="Apple", Category="Mobiles", Country="India", InStock=true, Name="IPhone 15 Max", Price=79999},
                    new Product { Id = 5,Brand="Apple", Category="Mobiles", Country="India", InStock=true, Name="IPhone 16", Price=69999},

            };

            // data seeding
            modelBuilder.Entity<Product>().HasData(products);

        }
    }
}
