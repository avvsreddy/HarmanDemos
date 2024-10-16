﻿using System;
using System.Collections.Generic;

namespace EFDbFirstDemo;

public partial class Customer
{
    public int Id { get; set; }

    public string? CustomerType { get; set; }

    public double Discount { get; set; }

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public string Name { get; set; } = null!;

    public string AddressCity { get; set; } = null!;

    public string AddressPostalCode { get; set; } = null!;

    public string AddressState { get; set; } = null!;

    public string AddressStreet { get; set; } = null!;
}
