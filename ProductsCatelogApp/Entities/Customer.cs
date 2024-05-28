namespace ProductsCatelogApp.Entities
{
    public class Customer : Person
    {
        public virtual Address Address { get; set; }
        public string? CustomerType { get; set; }
        public double Discount { get; set; }
    }
}
