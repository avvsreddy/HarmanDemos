namespace SimpleCalculatorApp
{
    /// <summary>
    /// Calculator will be used for calculating mathematical results
    /// </summary>
    public class Calculator // SRP BL
    {
        /// <summary>
        /// Find the sum of two non zero positive even numbers sum
        /// </summary>
        /// <param name="fno"></param>
        /// <param name="sno"></param>
        /// <returns></returns>
        /// <exception cref="ZeroNumberException"></exception>
        /// <exception cref="NegativeNumberException"></exception>
        /// <exception cref="NonEvenNumberException"></exception>
        public int FindSum(int fno, int sno) // BL - SRP
        {

            // only non zero positive even numbers

            /*
             * Multi
             * line
             comments
             */
            if (fno == 0 || sno == 0) // zero 
            {
                // throws zeronumberexpection when user provides zero values
                throw new ZeroNumberException("Enter non zero number only");
            }

            if (fno < 0 || sno < 0) // negative
            {
                throw new NegativeNumberException("Enter only non negative numbers only");
            }

            if (fno % 2 != 0 || sno % 2 != 0) // not even
            {
                throw new NonEvenNumberException("Enter only even numbers");
            }


            return fno + sno;
        }
    }


    public class NegativeNumberException : ApplicationException
    {
        public NegativeNumberException(string msg) : base(msg)
        {

        }
    }
    public class ZeroNumberException : ApplicationException
    {
        public ZeroNumberException(string msg) : base(msg)
        {

        }
    }

    public class NonEvenNumberException : ApplicationException
    {
        public NonEvenNumberException(string msg) : base(msg)
        {

        }
    }
}
