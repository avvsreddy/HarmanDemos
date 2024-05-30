using System.ComponentModel.DataAnnotations;

namespace CoolProductsCatalogService.Model.Entities
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [StringLength(60)]
        public string Name { get; set; }
        public int Price { get; set; }
        public bool InStock { get; set; }
        public string? Country { get; set; }
        public string? Brand { get; set; }
        public string? Category { get; set; }


    }
}
