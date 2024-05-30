using System.Net.Http.Json;

namespace CoolProductsApiClient
{

    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public bool inStock { get; set; }
        public string country { get; set; }
        public string brand { get; set; }
        public string category { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Get all products from https://localhost:44320/api/Products

            HttpClient http = new HttpClient();
            string url = "https://localhost:44320/api/Products";

            var result = http.GetFromJsonAsync<List<Product>>(url).GetAwaiter().GetResult();

            foreach (var item in result)
            {
                Console.WriteLine(item.name);
            }
        }
    }
}
