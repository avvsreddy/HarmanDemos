namespace BankApp.Business
{
    public class Account
    {
        public int AccNo { get; set; }
        public int CurrentBalance { get; set; }
        public int Pin { get; set; }
        public int MinBalance { get; set; }
        public bool IsActive { get; set; }
    }
}
