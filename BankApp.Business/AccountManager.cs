namespace BankApp.Business
{
    public class AccountManager
    {
        private IAccountRepository repo;
        public AccountManager(IAccountRepository repo)
        {

            this.repo = repo;

        }

        // Deposit
        // Business Rules
        //1. min deposit amount 500.00
        //2. account should be active
        //3. it should increase the balance 
        //4. after success it should return true
        //5. after successfull deposit transaction should save into db
        public bool Deposit(Account accToDeposit, int amountToDeposit)
        {

            //2
            if (!accToDeposit.IsActive)
            {
                throw new InactiveAccountException("This account is inactive");
            }
            //1
            if (amountToDeposit < 500)
            {
                throw new InvalidAmountException("Minimum deposit should 500 or more");
            }
            //3
            accToDeposit.CurrentBalance += amountToDeposit;
            //4

            //5. save transaction data into db

            //AccountRepository repo = new AccountRepository();
            repo.Save($"Deposit,{accToDeposit.AccNo},{amountToDeposit},{DateTime.Now}");


            return true;
        }



    }

    // DAL

    public interface IAccountRepository
    {
        bool Save(string msg);
    }

    public class AccountRepository : IAccountRepository
    {
        public bool Save(string msg)
        {
            // logic to save in file
            File.WriteAllText("d:\\account.log", msg);

            return true;
        }
    }
}
