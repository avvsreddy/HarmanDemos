using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsCatelogApp.Entities
{
    [ComplexType]
    public class Address
    {
        //public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
    }
}
