using System;
using System.Collections.Generic;

namespace school_demo;

public partial class EmployeeCategory
{
    public int EmployeeCategoryId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
