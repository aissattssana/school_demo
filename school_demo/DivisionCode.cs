﻿using System;
using System.Collections.Generic;

namespace school_demo;

public partial class DivisionCode
{
    public int DivisionCodeId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
