namespace SimpleCalculatorApp
{
    internal class Program // SRP - UI
    {
        static void Main(string[] args) // SRP - UI
        {
            // Accept two ints, find the sum them display the result
            //declarations
            int fno;
            int sno;
            int sum = 0;
            // UI Logic
            Console.Write("Enter first number: ");
            fno = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            sno = int.Parse(Console.ReadLine());

            // calculate - BL
            Calculator calc = new Calculator();
            sum = calc.FindSum(fno, sno);

            // UI Logic
            Console.WriteLine($"The sum of {fno} and {sno} is {sum}");

        }



    }
}
