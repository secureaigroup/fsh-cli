using System;
using System.Collections.Generic;

namespace FSHCodeGenerator.Models;

public partial class Job
{
    public int Id { get; set; }

    public int? StateId { get; set; }

    public string? StateName { get; set; }

    public string InvocationData { get; set; } = null!;

    public string Arguments { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? ExpireAt { get; set; }

    public virtual ICollection<Jobparameter> Jobparameters { get; set; } = new List<Jobparameter>();

    public virtual ICollection<Jobstate> Jobstates { get; set; } = new List<Jobstate>();

    public virtual ICollection<State> States { get; set; } = new List<State>();
}
