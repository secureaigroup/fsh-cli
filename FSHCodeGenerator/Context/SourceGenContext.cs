using System;
using System.Collections.Generic;
using FSHCodeGenerator.Models;
using Microsoft.EntityFrameworkCore;

namespace FSHCodeGenerator;

public partial class SourceGenContext : DbContext
{
    public SourceGenContext()
    {
    }

    public SourceGenContext(DbContextOptions<SourceGenContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aggregatedcounter> Aggregatedcounters { get; set; }

    public virtual DbSet<Audittrail> Audittrails { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<Counter> Counters { get; set; }

    public virtual DbSet<Distributedlock> Distributedlocks { get; set; }

    public virtual DbSet<Efmigrationshistory> Efmigrationshistories { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeState> EmployeeStates { get; set; }

    public virtual DbSet<Hash> Hashes { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<Jobparameter> Jobparameters { get; set; }

    public virtual DbSet<Jobqueue> Jobqueues { get; set; }

    public virtual DbSet<Jobstate> Jobstates { get; set; }

    public virtual DbSet<List> Lists { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Roleclaim> Roleclaims { get; set; }

    public virtual DbSet<Server> Servers { get; set; }

    public virtual DbSet<Set> Sets { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Tenant> Tenants { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Userclaim> Userclaims { get; set; }

    public virtual DbSet<Userlogin> Userlogins { get; set; }

    public virtual DbSet<Userrole> Userroles { get; set; }

    public virtual DbSet<Usertoken> Usertokens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("server=rojasnas;uid=root;password=Saipassword1;Database=testFSHdb;Allow User Variables=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aggregatedcounter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("aggregatedcounter");

            entity.HasIndex(e => e.Key, "IX_CounterAggregated_Key").IsUnique();

            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            entity.Property(e => e.Key).HasMaxLength(100);
        });

        modelBuilder.Entity<Audittrail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("audittrails");

            entity.Property(e => e.DateTime).HasMaxLength(6);
            entity.Property(e => e.TenantId).HasMaxLength(64);
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("brands");

            entity.Property(e => e.CreatedOn).HasMaxLength(6);
            entity.Property(e => e.DeletedOn).HasMaxLength(6);
            entity.Property(e => e.LastModifiedOn).HasMaxLength(6);
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.TenantId).HasMaxLength(64);
        });

        modelBuilder.Entity<Counter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("counter");

            entity.HasIndex(e => e.Key, "IX_Counter_Key");

            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            entity.Property(e => e.Key).HasMaxLength(100);
        });

        modelBuilder.Entity<Distributedlock>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("distributedlock");

            entity.Property(e => e.CreatedAt).HasMaxLength(6);
            entity.Property(e => e.Resource).HasMaxLength(100);
        });

        modelBuilder.Entity<Efmigrationshistory>(entity =>
        {
            entity.HasKey(e => e.MigrationId).HasName("PRIMARY");

            entity.ToTable("__efmigrationshistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("employees");

            entity.HasIndex(e => e.EmployeeStateId, "IX_Employees_EmployeeStateId");

            entity.Property(e => e.ContactNumber).HasMaxLength(15);
            entity.Property(e => e.CreatedOn).HasMaxLength(6);
            entity.Property(e => e.Custom1).HasMaxLength(128);
            entity.Property(e => e.Custom2).HasMaxLength(128);
            entity.Property(e => e.Custom3).HasMaxLength(128);
            entity.Property(e => e.DeletedOn).HasMaxLength(6);
            entity.Property(e => e.Department).HasMaxLength(32);
            entity.Property(e => e.Designation).HasMaxLength(50);
            entity.Property(e => e.DoB).HasColumnType("date");
            entity.Property(e => e.EmailAddress).HasMaxLength(128);
            entity.Property(e => e.EmployeeNumber).HasMaxLength(32);
            entity.Property(e => e.FirstName).HasMaxLength(32);
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.JobTitle).HasMaxLength(50);
            entity.Property(e => e.LastModifiedOn).HasMaxLength(6);
            entity.Property(e => e.LastName).HasMaxLength(32);
            entity.Property(e => e.MotherMaidenName).HasMaxLength(64);
            entity.Property(e => e.UserId).HasMaxLength(255);
            entity.Property(e => e.VehicleColor).HasMaxLength(32);
            entity.Property(e => e.VehicleMake).HasMaxLength(32);
            entity.Property(e => e.VehicleModel).HasMaxLength(32);
            entity.Property(e => e.VehicleRegisteredNumber).HasMaxLength(32);

            entity.HasOne(d => d.EmployeeState).WithMany(p => p.Employees)
                .HasForeignKey(d => d.EmployeeStateId)
                .HasConstraintName("FK_Employees_EmployeeStates_EmployeeStateId");
        });

        modelBuilder.Entity<EmployeeState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("employeestates");

            entity.Property(e => e.Access).HasMaxLength(1);
            entity.Property(e => e.CreatedOn).HasMaxLength(6);
            entity.Property(e => e.DeletedOn).HasMaxLength(6);
            entity.Property(e => e.LastModifiedOn).HasMaxLength(6);
            entity.Property(e => e.Name).HasMaxLength(32);
        });

        modelBuilder.Entity<Hash>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("hash");

            entity.HasIndex(e => new { e.Key, e.Field }, "IX_Hash_Key_Field").IsUnique();

            entity.Property(e => e.ExpireAt).HasMaxLength(6);
            entity.Property(e => e.Field).HasMaxLength(40);
            entity.Property(e => e.Key).HasMaxLength(100);
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("job");

            entity.HasIndex(e => e.StateName, "IX_Job_StateName");

            entity.Property(e => e.CreatedAt).HasMaxLength(6);
            entity.Property(e => e.ExpireAt).HasMaxLength(6);
            entity.Property(e => e.StateName).HasMaxLength(20);
        });

        modelBuilder.Entity<Jobparameter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("jobparameter");

            entity.HasIndex(e => e.JobId, "FK_JobParameter_Job");

            entity.HasIndex(e => new { e.JobId, e.Name }, "IX_JobParameter_JobId_Name").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(40);

            entity.HasOne(d => d.Job).WithMany(p => p.Jobparameters)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK_JobParameter_Job");
        });

        modelBuilder.Entity<Jobqueue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("jobqueue");

            entity.HasIndex(e => new { e.Queue, e.FetchedAt }, "IX_JobQueue_QueueAndFetchedAt");

            entity.Property(e => e.FetchToken).HasMaxLength(36);
            entity.Property(e => e.FetchedAt).HasMaxLength(6);
            entity.Property(e => e.Queue).HasMaxLength(50);
        });

        modelBuilder.Entity<Jobstate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("jobstate");

            entity.HasIndex(e => e.JobId, "FK_JobState_Job");

            entity.Property(e => e.CreatedAt).HasMaxLength(6);
            entity.Property(e => e.Name).HasMaxLength(20);
            entity.Property(e => e.Reason).HasMaxLength(100);

            entity.HasOne(d => d.Job).WithMany(p => p.Jobstates)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK_JobState_Job");
        });

        modelBuilder.Entity<List>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("list");

            entity.Property(e => e.ExpireAt).HasMaxLength(6);
            entity.Property(e => e.Key).HasMaxLength(100);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("products");

            entity.HasIndex(e => e.BrandId, "IX_Products_BrandId");

            entity.Property(e => e.CreatedOn).HasMaxLength(6);
            entity.Property(e => e.DeletedOn).HasMaxLength(6);
            entity.Property(e => e.ImagePath).HasMaxLength(2048);
            entity.Property(e => e.LastModifiedOn).HasMaxLength(6);
            entity.Property(e => e.Name).HasMaxLength(1024);
            entity.Property(e => e.Rate).HasPrecision(65, 30);
            entity.Property(e => e.TenantId).HasMaxLength(64);

            entity.HasOne(d => d.Brand).WithMany(p => p.Products)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("FK_Products_Brands_BrandId");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("roles");

            entity.HasIndex(e => new { e.NormalizedName, e.TenantId }, "RoleNameIndex").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
            entity.Property(e => e.TenantId).HasMaxLength(64);
        });

        modelBuilder.Entity<Roleclaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("roleclaims");

            entity.HasIndex(e => e.RoleId, "IX_RoleClaims_RoleId");

            entity.Property(e => e.CreatedOn).HasMaxLength(6);
            entity.Property(e => e.TenantId).HasMaxLength(64);

            entity.HasOne(d => d.Role).WithMany(p => p.Roleclaims)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_RoleClaims_Roles_RoleId");
        });

        modelBuilder.Entity<Server>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("server");

            entity.Property(e => e.Id).HasMaxLength(100);
            entity.Property(e => e.LastHeartbeat).HasMaxLength(6);
        });

        modelBuilder.Entity<Set>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("set");

            entity.HasIndex(e => new { e.Key, e.Value }, "IX_Set_Key_Value").IsUnique();

            entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            entity.Property(e => e.Key).HasMaxLength(100);
            entity.Property(e => e.Value).HasMaxLength(256);
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("state");

            entity.HasIndex(e => e.JobId, "FK_HangFire_State_Job");

            entity.Property(e => e.CreatedAt).HasMaxLength(6);
            entity.Property(e => e.Name).HasMaxLength(20);
            entity.Property(e => e.Reason).HasMaxLength(100);

            entity.HasOne(d => d.Job).WithMany(p => p.States)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK_HangFire_State_Job");
        });

        modelBuilder.Entity<Tenant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tenants");

            entity.HasIndex(e => e.Identifier, "IX_Tenants_Identifier").IsUnique();

            entity.Property(e => e.Id).HasMaxLength(64);
            entity.Property(e => e.ValidUpto).HasMaxLength(6);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("users");

            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => new { e.NormalizedUserName, e.TenantId }, "UserNameIndex").IsUnique();

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.LockoutEnd).HasMaxLength(6);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.ObjectId).HasMaxLength(256);
            entity.Property(e => e.RefreshTokenExpiryTime).HasMaxLength(6);
            entity.Property(e => e.TenantId).HasMaxLength(64);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<Userclaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("userclaims");

            entity.HasIndex(e => e.UserId, "IX_UserClaims_UserId");

            entity.Property(e => e.TenantId).HasMaxLength(64);

            entity.HasOne(d => d.User).WithMany(p => p.Userclaims)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserClaims_Users_UserId");
        });

        modelBuilder.Entity<Userlogin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("userlogins");

            entity.HasIndex(e => new { e.LoginProvider, e.ProviderKey, e.TenantId }, "IX_UserLogins_LoginProvider_ProviderKey_TenantId").IsUnique();

            entity.HasIndex(e => e.UserId, "IX_UserLogins_UserId");

            entity.Property(e => e.TenantId).HasMaxLength(64);

            entity.HasOne(d => d.User).WithMany(p => p.Userlogins)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserLogins_Users_UserId");
        });

        modelBuilder.Entity<Userrole>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.RoleId }).HasName("PRIMARY");

            entity.ToTable("userroles");

            entity.HasIndex(e => e.RoleId, "IX_UserRoles_RoleId");

            entity.Property(e => e.TenantId).HasMaxLength(64);

            entity.HasOne(d => d.Role).WithMany(p => p.Userroles)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_UserRoles_Roles_RoleId");

            entity.HasOne(d => d.User).WithMany(p => p.Userroles)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserRoles_Users_UserId");
        });

        modelBuilder.Entity<Usertoken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name }).HasName("PRIMARY");

            entity.ToTable("usertokens");

            entity.Property(e => e.TenantId).HasMaxLength(64);

            entity.HasOne(d => d.User).WithMany(p => p.Usertokens)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserTokens_Users_UserId");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
