using System.ComponentModel.DataAnnotations;

namespace ProductsCatelogApp.Entities
{
    //[Table("tbl_items")]
    public class Product // Entity Class
    {
        //[Key]
        public int ProductID { get; set; }
        //[Required]
        [MaxLength(100)]
        public required string Name { get; set; }
        public int Price { get; set; }

        [MaxLength(50)]
        public string? Brand { get; set; }

        // Navigation Property
        public virtual Category Category { get; set; }

        public virtual List<Supplier> Suppliers { get; set; }
    }
}
