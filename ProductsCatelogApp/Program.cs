using ProductsCatelogApp.Data;

namespace ProductsCatelogApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // store product info into database

            //Product p = new Product { Name = "IPhone 16", Price = 99999 };
            ProductsCatelogDbContext db = new ProductsCatelogDbContext();
            // add product
            //db.Products.Add(p);
            // save to db
            //db.SaveChanges();
            //Console.WriteLine("product inserted");


            // get all products and display
            // linq to entities

            //var allProducts = from p in db.Products
            //                  select p;

            //foreach (var product in allProducts)
            //{
            //    Console.WriteLine(product.Name + " " + product.Price);
            //}


            // update

            // get the entity to update
            // get the product by id

            //var productToEdit = (from p in db.Products
            //                     where p.ProductID == 1
            //                     select p).FirstOrDefault();

            //productToEdit.Price = 88888;

            //db.SaveChanges();

            // delete
            var productToDelete = (from p in db.Products
                                   where p.ProductID == 1
                                   select p).FirstOrDefault();

            db.Products.Remove(productToDelete);

            db.SaveChanges();

        }
    }
}
