using Microsoft.EntityFrameworkCore;
using ProductsCatelogApp.Data;
using ProductsCatelogApp.Entities;

namespace ProductsCatelogApp
{

    //public class PNameCName
    //{
    //    public string PName { get; set; }
    //    public string CName { get; set; }

    //    public int Cost { get; set; }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {

            ProductsCatelogDbContext db = new ProductsCatelogDbContext();

            // get only product name and category name and display

            // select p.name,c.categoryname from products
            //var allProducts = db.Products.Include("Category");
            //foreach (var item in allProducts)
            //{
            //    Console.WriteLine(item.Name + "\t" + item.Category.CategoryName);
            //}


            var allProducts = from p in db.Products.Include("Category")
                              select new { PName = p.Name, Cost = p.Price, CName = p.Category.CategoryName };

            foreach (var product in allProducts)
            {
                Console.WriteLine($"{product.PName} \t {product.CName}");
            }


            // Increase all products price to 1000
            // Get all the products then update the price
            // Save the changes

            //var allProducts = db.Products;
            //var allProducts = from p in db.Products select p;
            //foreach (var product in allProducts)
            //{
            //    product.Price += 1000;
            //}

            //db.SaveChanges();

            //db.Products.Skip(2000).Take(1000); // Pagination

        }

        private static void ExeRawSql(ProductsCatelogDbContext db)
        {
            // Execute Raw sql
            string sqlUpdate = "update products set price = price + 1001";
            int count = db.Database.ExecuteSqlRaw(sqlUpdate);
            Console.WriteLine($"{count} records updated");
        }

        private static void egarloading(ProductsCatelogDbContext db)
        {
            //  get all products and display pname and cname

            var result = from p in db.Products.Include(p => p.Category) select p;
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} \t {item.Category.CategoryName}");
            }

            // Egar Loading
            // Lazy Loading
        }

        private static void AddNewProductIntoExistingCategory(ProductsCatelogDbContext db)
        {
            // Add a new product into existing category

            var existingCategory = db.Categories.Find(1);
            var p = new Product { Name = "Galaxy Watch 6", Brand = "Samsung", Price = 67000, Category = existingCategory };
            db.Products.Add(p);
            db.SaveChanges();
        }

        private static void AddNewProductAndNewCategory(ProductsCatelogDbContext db)
        {
            //case 1: create new product and associate with new category
            Product p = new Product { Name = "IWatch Pro", Brand = "Apple", Price = 45000 };
            Category category = new Category { CategoryName = "Smart Watches" };
            p.Category = category;

            db.Products.Add(p);
            //db.Categories.Add(category);

            db.SaveChanges();
        }

        private static void save(ProductsCatelogDbContext db)
        {
            Product p = new Product { Name = "IPhone 16 Plus", Price = 99999 };
            //ProductsCatelogDbContext db = new ProductsCatelogDbContext();
            //add product
            db.Products.Add(p);
            //save to db
            db.SaveChanges();
            Console.WriteLine("product inserted");
            //return db;
        }

        private static void select2(ProductsCatelogDbContext db)
        {
            // LinqToEntities
            var allProducts = from p in db.Products
                              select p;

            foreach (var product in allProducts)
            {
                Console.WriteLine(product.Name + " " + product.Price);
            }
        }

        private static void edit(ProductsCatelogDbContext db)
        {
            //var productToEdit = (from p in db.Products
            //                     where p.ProductID == 1
            //                     select p).FirstOrDefault();

            var productToEdit = db.Products.Find(1);
            if (productToEdit != null)
            {
                productToEdit.Price = 123456;
            }
            ProductsCatelogDbContext newDB = new ProductsCatelogDbContext();
            newDB.Entry(productToEdit).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            newDB.SaveChanges();
        }

        private static void Delete(ProductsCatelogDbContext db)
        {
            var productToDelete = (from p in db.Products
                                   where p.ProductID == 1
                                   select p).FirstOrDefault();

            db.Products.Remove(productToDelete);

            db.SaveChanges();
        }
    }
}
