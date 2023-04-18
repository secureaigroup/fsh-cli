using System;
using System.Collections.Generic;

namespace FSHCodeGenerator.Models;

public partial class Employee
{
    public Guid Id { get; set; }

    public Guid? EmployeestateId { get; set; }

    public string EmployeeNumber { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? MotherMaidenName { get; set; }

    public string? Designation { get; set; }

    public string? Department { get; set; }

    public string? ContactNumber { get; set; }

    public string? EmailAddress { get; set; }

    public DateTime DoB { get; set; }

    public byte[]? PhotoId { get; set; }

    public byte[]? ProfilePicture { get; set; }

    public string? JobTitle { get; set; }

    public Guid? SupervisorEmployeeId { get; set; }

    public Guid? ShiftId { get; set; }

    public string Gender { get; set; } = null!;

    public bool IsWatchListed { get; set; }

    public bool HasVehicle { get; set; }

    public string? VehicleMake { get; set; }

    public string? VehicleModel { get; set; }

    public string? VehicleColor { get; set; }

    public string? VehicleRegisteredNumber { get; set; }

    public bool IsActive { get; set; }

    public string? Custom1 { get; set; }

    public string? Custom2 { get; set; }

    public string? Custom3 { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid LastModifiedBy { get; set; }

    public DateTime? LastModifiedOn { get; set; }

    public DateTime? DeletedOn { get; set; }

    public Guid? DeletedBy { get; set; }

    public string TenantId { get; set; } = null!;

    public virtual Employeestate? Employeestate { get; set; }

    public virtual Shift? Shift { get; set; }
}
