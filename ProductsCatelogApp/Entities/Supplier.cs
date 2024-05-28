namespace ProductsCatelogApp.Entities
{
    public class Supplier : Person
    {
        //public int SupplierID { get; set; }
        //[Required]
        //public required string SupplierName { get; set; }
        //public string? Mobile { get; set; }
        //public string? Email { get; set; }

        public virtual Address Address { get; set; }
        public string? GSTNo { get; set; }
        public int? Rating { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
