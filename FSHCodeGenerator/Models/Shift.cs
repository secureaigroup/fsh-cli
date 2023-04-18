using System;
using System.Collections.Generic;

namespace FSHCodeGenerator.Models;

public partial class Shift
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string DaysOfWeek { get; set; } = null!;

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public bool Enabled { get; set; }

    public string TenantId { get; set; } = null!;

    public Guid CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid LastModifiedBy { get; set; }

    public DateTime? LastModifiedOn { get; set; }

    public DateTime? DeletedOn { get; set; }

    public Guid? DeletedBy { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<External> Externals { get; set; } = new List<External>();
}
