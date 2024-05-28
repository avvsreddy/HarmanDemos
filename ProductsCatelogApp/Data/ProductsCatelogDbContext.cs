using Microsoft.EntityFrameworkCore;
using ProductsCatelogApp.Entities;

namespace ProductsCatelogApp.Data
{
    public class ProductsCatelogDbContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // map to db
            optionsBuilder
                .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                .UseLazyLoadingProxies() // for lazy loding config
                .UseSqlServer("server=(localdb)\\mssqllocaldb;database=HarmanProductsCatelogDB;Trusted_Connection=True;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // ef core 7/8
            //modelBuilder.Entity<Person>().UseTphMappingStrategy();
            //modelBuilder.Entity<Person>().UseTptMappingStrategy();
            modelBuilder.Entity<Person>().UseTpcMappingStrategy();
        }


        // map to tables

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
