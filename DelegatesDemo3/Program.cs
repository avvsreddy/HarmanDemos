namespace DelegatesDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // customer 1
            //TODO: customer should register/subscribe for notification and should receive notifications only after the transactions

            Account acc1 = new Account();
            acc1.notify += Notification.SendSMS;
            //acc1.Subscribe(Notification.SendSMS);
            acc1.notify += Notification.SendEmail;
            //acc1.Subscribe(Notification.SendEmail);
            //acc1.notify -= Notification.SendSMS;
            acc1.notify += Notification.SendWhatsApp;
            //acc1.Subscribe(Notification.SendWhatsApp);

            //acc1.notify("Your account has been credited $999999999999999999");


            //acc1.inotify = new Notification();
            //acc1.Deposit(5000);
            //
            //acc1.Withdraw(1000);
            Console.WriteLine($"My Balance {acc1.Balance}");
        }
    }


    public class Account // OCP SRP
    {
        public int Balance { get; private set; }

        public event NotifyDelegate notify;// = new NotifyDelegate(Notification.SendSMS);
        //public INotify inotify = null;

        //public void Subscribe(NotifyDelegate n)
        //{
        //    this.notify += n;
        //}

        //public void Unsubscribe(NotifyDelegate n)
        //{
        //    this.notify -= n;
        //}

        public void Deposit(int amount)
        {
            Balance += amount;
            // write logic to send sms
            string msg = $"Account Deposited Rs. {amount} successfully....";
            //Notification.SendSMS(msg);
            //Notification.SendEmail(msg);
            if (notify != null)
            {
                notify(msg);
                //inotify.OnNotify(msg);
            }
        }
        public void Withdraw(int amount)  // OCP
        {
            Balance -= amount;
            // write logic to send sms
            string msg = $"Account Withdrawn Rs. {amount} successfully....";
            //Notification.SendSMS(msg);
            //Notification.SendEmail(msg);
            if (notify != null)
            {
                notify(msg);
                //inotify.OnNotify(msg);
            }
        }

    }

    public delegate void NotifyDelegate(string msg);

    public interface INotify
    {
        void OnNotify(string msg);
    }

    public class Notification : INotify
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

        public static void SendWhatsApp(string msg)
        {
            // sms logic
            Console.WriteLine($"WhatsApp: {msg}");
        }

        public void OnNotify(string msg)
        {
            Console.WriteLine($"Interface Notification: {msg}");
        }
    }
}
