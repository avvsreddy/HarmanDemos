namespace DelegatesDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // customer 1
            //TODO: customer should register/subscribe for notification
            Account acc1 = new Account();
            acc1.Deposit(5000);
            //
            acc1.Withdraw(1000);
            Console.WriteLine($"My Balance {acc1.Balance}");
        }
    }


    public class Account // OCP
    {
        public int Balance { get; private set; }

        public void Deposit(int amount)
        {
            Balance += amount;
            // write logic to send sms
            string msg = $"Account Deposited Rs. {amount} successfully....";
            Notification.SendSMS(msg);
            Notification.SendEmail(msg);
        }
        public void Withdraw(int amount)  // OCP
        {
            Balance -= amount;
            // write logic to send sms
            string msg = $"Account Withdrawn Rs. {amount} successfully....";
            Notification.SendSMS(msg);
            Notification.SendEmail(msg);
        }

    }


    public class Notification
    {
        public static void SendSMS(string msg)
        {
            // sms logic
            Console.WriteLine($"SMS: {msg}");
        }

        public static void SendEmail(string msg)
        {
            // sms logic
            Console.WriteLine($"Email: {msg}");
        }
    }
}
