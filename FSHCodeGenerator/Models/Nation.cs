using System;
using System.Collections.Generic;

namespace FSHCodeGenerator.Models;

public partial class Nation
{
    public int NationId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<External> Externals { get; set; } = new List<External>();
}
