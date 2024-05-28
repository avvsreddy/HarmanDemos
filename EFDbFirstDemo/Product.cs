using System;
using System.Collections.Generic;

namespace EFDbFirstDemo;

public partial class Product
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public int Price { get; set; }

    public string? Brand { get; set; }

    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
}
