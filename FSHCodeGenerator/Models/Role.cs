using System;
using System.Collections.Generic;

namespace FSHCodeGenerator.Models;

public partial class Role
{
    public string Id { get; set; } = null!;

    public string? Description { get; set; }

    public string TenantId { get; set; } = null!;

    public string? Name { get; set; }

    public string? NormalizedName { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public virtual ICollection<Roleclaim> Roleclaims { get; set; } = new List<Roleclaim>();

    public virtual ICollection<Userrole> Userroles { get; set; } = new List<Userrole>();
}
