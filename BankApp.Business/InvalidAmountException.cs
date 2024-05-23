namespace BankApp.Business
{
    public class InvalidAmountException : ApplicationException
    {
        public InvalidAmountException(string msg) : base(msg)
        {

        }
    }
}
