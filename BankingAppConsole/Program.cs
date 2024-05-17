namespace BankingAppConsole
{
    internal class Program
    {
        static void Main(string[] args) // UI
        {

            try
            {
                Account acc; // ref
                acc = new Account(); // instatiate
                acc.AccNo = 111;
                acc.MinBalance = 1000;
                acc.CurrentBalance = 1000;
                acc.Pin = 1234;
                acc.IsActive = true;

                acc.Deposit(4000);
                //acc.Withdraw(4000, 1234);
                Console.WriteLine("Transaction is success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }


    class Account // BL
    {
        public int AccNo { get; set; }
        public int CurrentBalance { get; set; }
        public bool IsActive { get; set; }
        public int Pin { get; set; }
        public int MinBalance { get; set; }

        public void Deposit(int amount)
        {
            // Rules
            // 1. Active
            if (!IsActive)
            {
                throw new InActiveAccountException("Account is inactive");
            }
            // 2. minimim deposit is 1000
            if (amount < 1000)
            {
                throw new InvalidAmountException("Minimum deposit amount is 1000");
            }
            try
            {
                CurrentBalance += amount;
                DbRepository repo = new DbRepository();
                repo.Save("Deposit is success");
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Database error, please try later");
                // log
                // log frameworks - nLog/serilog/sdfdfdf
                //File.WriteAllText("error.log", ex.Message);

                throw ex; // is must
            }
        }

        public void Withdraw(int amount, int pin)
        {
            // Rules
            // 1. Active
            if (!IsActive)
            {
                throw new InActiveAccountException("Account is inactive");
            }
            // 2. Sufficient Balance
            if ((CurrentBalance - MinBalance) < amount)
            {
                // 5000 - 1000 < 4000
                throw new InvalidAmountException("Insufficient balance");
            }
            // 3. Must maintain min balance 1000

            // 4. pin must match
            if (Pin != pin)
            {
                throw new InvalidPinException("Invalid Pin");
            }
            // 5. max limit 5000
            // 6. min limit 500
            if (amount > 5000 || amount < 500)
            {
                throw new InvalidAmountException("Min is 5000 and max is 500");
            }

            CurrentBalance -= amount;
            DbRepository repo = new DbRepository();
            repo.Save("Withdraw is success");
        }
    }


    public class InActiveAccountException : ApplicationException
    {
        public InActiveAccountException(string msg) : base(msg)
        {

        }
    }

    public class InvalidAmountException : ApplicationException
    {
        public InvalidAmountException(string msg) : base(msg)
        {

        }
    }

    public class InvalidPinException : ApplicationException
    {
        public InvalidPinException(string msg) : base(msg)
        {

        }
    }


    class DbRepository // DAL
    {
        public void Save(string msg)
        {
            // write a logic to store msg into database
            //;;;
            //sdfsdf
            //sffsdf
            throw new Exception("Database is down");
        }

    }
}
