namespace CollectionsDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Static Collections - Array
            // need to store 5 ints and procrss it


            int a = 5;

            int[] b = new int[3];
            // store
            b[0] = 1; b[1] = 2; b[2] = 3;
            // read
            a = b[0];
            for (int i = 0; i < b.Length; i++)
            {
                // Console.WriteLine(b[i]);
            }

            int[] array1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] array2 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] array3 = { 1, 2, 3, 4 };
            int[] array4 = [1, 2, 3, 4];


            // 2D array
            int[,] twodArray = new int[3, 5];
            twodArray[1, 1] = 10;

            // Jagged Arrays
            // 1. create rows
            int[][] scores = new int[3][];
            // 2. create col for each row
            scores[0] = new int[3];
            scores[1] = new int[5];
            scores[2] = new int[10];


            int[] numbers = { 12, 32, 36, 4, 15, 6, 77, 89, 9 };
            int max = numbers.Max();
            Console.WriteLine($"Max={max}");
            int min = numbers.Min();
            Console.WriteLine($"Max={min}");
            int sum = numbers.Sum();
            Console.WriteLine($"Sum={sum}");
            double avg = numbers.Average();
            Console.WriteLine($"Double {avg}");


            //Console.WriteLine("Before sort");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Array.Sort(numbers);
            //Array.Reverse(numbers);

            //Console.WriteLine("After sort");
            //foreach (int n in numbers)
            //{
            //    Console.WriteLine(n);
            //}



        }
    }
}
