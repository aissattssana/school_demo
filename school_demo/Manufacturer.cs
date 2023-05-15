﻿using System;
using System.Collections.Generic;

namespace school_demo;

public partial class Manufacturer
{
    public int ManufacturerId { get; set; }

    public string? Name { get; set; }

    public DateTime? StartupDate { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
