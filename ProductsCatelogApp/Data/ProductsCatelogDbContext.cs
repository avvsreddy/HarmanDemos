using Microsoft.EntityFrameworkCore;
using ProductsCatelogApp.Entities;

namespace ProductsCatelogApp.Data
{
    public class ProductsCatelogDbContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // map to db
            optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb;database=HarmanProductsCatelogDB;Trusted_Connection=True");
        }



        // map to tables

        public DbSet<Product> Products { get; set; }


    }
}
