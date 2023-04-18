using System;
using System.Collections.Generic;

namespace FSHCodeGenerator.Models;

public partial class Employeestate
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Access { get; set; } = null!;

    public bool Enabled { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid LastModifiedBy { get; set; }

    public DateTime? LastModifiedOn { get; set; }

    public DateTime? DeletedOn { get; set; }

    public Guid? DeletedBy { get; set; }

    public string TenantId { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
