namespace LinqDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // get all even numbers into another array and display
            // table: numbers
            // col: number
            // SQL: select number from numbers where number mod 2 = 0

            //int[] evens = new int[numbers.Length];
            //foreach (int i in numbers) 
            //{
            //    if (numbers[i] % 2 == 0)
            //        evens[i] = numbers[i];
            //}

            // SQL: select number from numbers where number mod 2 = 0
            // LINQ to Objects
            var evens = from n in numbers where n % 2 == 0 select n;
            //foreach (var item in evens)
            //{
            //    Console.WriteLine(item);
            //}

            List<int> list = new List<int>() { 23, 12, 5, 54, 23, 66, 24, 7, 89, 45, 26 };
            //SQL: select number from numbers where number mod 2 = 0 order by number desc
            // LINQ
            var sorterdEvens = from n in list where n % 2 == 0 orderby n descending select n;
            foreach (var item in sorterdEvens)
            {
                Console.WriteLine(item);
            }

            // LINQ Expression (keywords)

            var evens2 = from n in numbers where n % 2 == 0 select n;
            // LINQ Extension Methods = Lambda Expression
            var evens3 = numbers.Where(n => n % 2 == 0).OrderByDescending(x => x).Select(y => y);
        }


        //public static bool IsEven(int n)
        //{
        //    return (n % 2 == 0);
        //}
    }
}
