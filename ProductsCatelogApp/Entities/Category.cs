using System.ComponentModel.DataAnnotations;

namespace ProductsCatelogApp.Entities
{
    //[Table("table_name")]
    public class Category
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(50)]
        public string CategoryName { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
