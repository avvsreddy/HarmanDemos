namespace EFDbFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DB First Approach");

            // get all products


            HarmanProductsCatelogDbContext db = new HarmanProductsCatelogDbContext();
            var allProducts = db.Products;
            foreach (var product in allProducts)
            {
                Console.WriteLine(product.Name);
            }

        }
    }
}
