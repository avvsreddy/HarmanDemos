namespace LinqDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var evens = (from n in ints where n % 2 == 0 select n).ToList();

            ints.Add(10);

            foreach (var item in evens)
            {
                Console.WriteLine(item);
            }



        }

        static List<int> GetEvens()
        {
            List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var evens = from n in ints where n % 2 == 0 select n;

            return evens.ToList();
        }
    }
}
