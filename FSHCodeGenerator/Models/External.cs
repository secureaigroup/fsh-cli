using System;
using System.Collections.Generic;

namespace FSHCodeGenerator.Models;

public partial class External
{
    public Guid Id { get; set; }

    public string ExternalNumber { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? MotherMaidenName { get; set; }

    public Guid? ContactEmployeeId { get; set; }

    public string? EmailAddress { get; set; }

    public string? ContactNumber { get; set; }

    public string? BadgeNumber { get; set; }

    public string? CompanyName { get; set; }

    public string? Designation { get; set; }

    public string? CompanyIdnumber { get; set; }

    public DateTime? DoB { get; set; }

    public string Gender { get; set; } = null!;

    public bool IsSupplier { get; set; }

    public byte[]? PhotoId { get; set; }

    public byte[]? PermitId { get; set; }

    public byte[]? Passport { get; set; }

    public byte[]? ProfilePicture { get; set; }

    public bool? HasVehicle { get; set; }

    public bool? IsMexican { get; set; }

    public DateTime? PermitExpiryDate { get; set; }

    public string? VehicleMake { get; set; }

    public string? VehicleModel { get; set; }

    public string? VehicleColor { get; set; }

    public string? VehicleRegisteredNumber { get; set; }

    public string? Matter { get; set; }

    public bool IsWatchListed { get; set; }

    public string? Observations { get; set; }

    public DateTime? AllowedUntil { get; set; }

    public bool IsActive { get; set; }

    public Guid? ExternalStateId { get; set; }

    public Guid? ShiftId { get; set; }

    public int? NationalityId { get; set; }

    public int NationId { get; set; }

    public string TenantId { get; set; } = null!;

    public Guid CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid LastModifiedBy { get; set; }

    public DateTime? LastModifiedOn { get; set; }

    public DateTime? DeletedOn { get; set; }

    public Guid? DeletedBy { get; set; }

    public virtual Externalstate? ExternalState { get; set; }

    public virtual Nation Nation { get; set; } = null!;

    public virtual Shift? Shift { get; set; }
}
