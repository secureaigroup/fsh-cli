using System;
using System.Collections.Generic;

namespace FSHCodeGenerator.Models;

public partial class ExternalState
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Access { get; set; } = null!;

    public bool Enabled { get; set; }

    public string TenantId { get; set; } = null!;

    public Guid CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid LastModifiedBy { get; set; }

    public DateTime? LastModifiedOn { get; set; }

    public DateTime? DeletedOn { get; set; }

    public Guid? DeletedBy { get; set; }

    public virtual ICollection<External> Externals { get; set; } = new List<External>();
}
