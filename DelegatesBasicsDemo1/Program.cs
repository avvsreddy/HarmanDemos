namespace DelegatesBasicsDemo1
{

    //public class MyDelegate : Delegate
    //{

    //}

    // Step 1: Declare the Delegate
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string msg);

    public class Program
    {
        static void Main(string[] args)
        {
            // Direct Method Invocation
            //M1();

            // Indirect Method Invocation
            //Delegate d = new Delegate();

            // Step 2: Instantiate and Initialize
            MyDelegate d = new MyDelegate(M1); // singlecast delegate

            MyDelegate2 delegate2 = new MyDelegate2(M3); // Multicaste delegate
            delegate2 += M2; // Subscription
            // Step 3: Invoke
            //d.Invoke();
            //d();
            delegate2 -= M3; // Unsubscription
            delegate2("hello");

        }

        public static void M1()
        {
            Console.WriteLine("M1 Called");
        }

        public static void M2(string str)
        {
            Console.WriteLine($"M2 Called with {str}");
        }
        public static void M3(string str)
        {
            Console.WriteLine($"M3 Called with {str}");
        }
    }
}
