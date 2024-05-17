namespace SimpleCalculatorApp
{
    internal class Program // SRP - UI
    {
        static void Main(string[] args) // SRP - UI
        {
            // Accept two ints, find the sum them display the result
            //declarations
            while (true)
            {
                try
                {
                    int fno;
                    int sno;
                    int sum = 0;
                    // UI Logic
                    Console.Write("Enter first number: ");
                    fno = int.Parse(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    sno = int.Parse(Console.ReadLine());

                    // open db connection

                    // read
                    // write

                    // calculate - BL
                    Calculator calc = new Calculator();
                    sum = calc.FindSum(fno, sno);

                    // UI Logic
                    Console.WriteLine($"The sum of {fno} and {sno} is {sum}");


                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter only integer number");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Please enter small integer numbers only");
                }

                catch (NonEvenNumberException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex) // Catch All Block
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    //Console.WriteLine("Finally Block");
                    // close db
                }
            }

        }



    }
}
