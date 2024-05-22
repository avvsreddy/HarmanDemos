using System.Configuration;

namespace POSCasestudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BillingSystem billingSystem = new BillingSystem();
            billingSystem.GenerateBill();
        }
    }


    public class TaxCalculatorFactory
    {

        public static readonly TaxCalculatorFactory Instance = new TaxCalculatorFactory();

        private TaxCalculatorFactory()
        {

        }
        public virtual ITaxCalculatorStrategy CreateTaxCalculator()
        {
            // read config data
            string className = ConfigurationManager.AppSettings["CALC"];
            // Reflextion
            Type theType = Type.GetType(className);
            return (ITaxCalculatorStrategy)Activator.CreateInstance(theType);

            //return new APTaxCalculator();
        }
    }




    public class BillingSystem
    {
        public void GenerateBill()
        {
            // Scan all products
            // Calculate Total

            // Apply discounts
            // Apply membership benifits
            // Apply Coupons

            double amount = 5600;

            TaxCalculatorFactory factory1 = TaxCalculatorFactory.Instance;
            Console.WriteLine($"factory 1 {factory1.GetHashCode()}");
            TaxCalculatorFactory factory2 = TaxCalculatorFactory.Instance;
            Console.WriteLine($"factory 2 {factory2.GetHashCode()}");
            ITaxCalculatorStrategy taxCalc = factory1.CreateTaxCalculator();
            //ITaxCalculatorStrategy taxCalc = TaxCalculatorFactory.CreateTaxCalculator();
            double tax = taxCalc.CalculateTax(amount);
            // Calculate Tax

            // Generate Bill
            // Payment
        }
    }

    public interface ITaxCalculatorStrategy
    {
        double CalculateTax(double amount);
    }

    public class KATaxCalculator : ITaxCalculatorStrategy
    {
        public double CalculateTax(double amount)
        {
            // KA
            int sgst = 100;
            int cgst = 100;
            int ec = 50;
            int sbt = 50;
            int totalTax = sgst + cgst + ec + sbt;
            Console.WriteLine("Using KA Tax Calculator");
            return totalTax;
        }
    }

    public class APTaxCalculator : ITaxCalculatorStrategy
    {
        public double CalculateTax(double amount)
        {
            // AP
            int sgst = 100;
            int cgst = 100;
            int ec = 50;
            int sbt = 50;
            int totalTax = sgst + cgst + ec + sbt;
            Console.WriteLine("Using AP Tax Calculator");
            return totalTax;
        }
    }

    public class UPTaxCalculator : ITaxCalculatorStrategy
    {
        public double CalculateTax(double amount)
        {
            // UP
            int sgst = 100;
            int cgst = 100;
            int ec = 50;
            int sbt = 50;
            int totalTax = sgst + cgst + ec + sbt;
            Console.WriteLine("Using UP Tax Calculator");
            return totalTax;
        }
    }


}
