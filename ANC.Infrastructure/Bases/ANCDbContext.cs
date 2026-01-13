using ANC.Domain.Bases;
using ANC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ANC.Infrastructure.Bases
{
	public class ANCDbContext : DbContext
	{
		public ANCDbContext(DbContextOptions<ANCDbContext> options) : base(options)
		{
		}

		// DbSets
		public virtual DbSet<Branch> Branches => Set<Branch>();
		public virtual DbSet<User> Users => Set<User>();
		public virtual DbSet<Employee> Employees => Set<Employee>();
		public virtual DbSet<Room> Rooms => Set<Room>();
		public virtual DbSet<Device> Devices => Set<Device>();
		public virtual DbSet<WorkLocation> WorkLocations => Set<WorkLocation>();
		public virtual DbSet<Shift> Shifts => Set<Shift>();
		public virtual DbSet<Schedule> Schedules => Set<Schedule>();
		public virtual DbSet<AttendanceRaw> AttendanceRaws => Set<AttendanceRaw>();
		public virtual DbSet<AttendanceDaily> AttendanceDailies => Set<AttendanceDaily>();
		public virtual DbSet<AttendanceMonthly> AttendanceMonthlies => Set<AttendanceMonthly>();
		public virtual DbSet<AttendanceRequest> AttendanceRequests => Set<AttendanceRequest>();
		public virtual DbSet<ApprovalStep> ApprovalSteps => Set<ApprovalStep>();
		public virtual DbSet<Certificate> Certificates => Set<Certificate>();
		public virtual DbSet<EmploymentContract> EmploymentContracts => Set<EmploymentContract>();
		public virtual DbSet<AuditLog> AuditLogs => Set<AuditLog>();

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Configure DateTime to UTC conversion
			foreach (var entityType in modelBuilder.Model.GetEntityTypes())
			{
				foreach (var property in entityType.GetProperties())
				{
					if (property.ClrType == typeof(DateTime))
					{
						property.SetValueConverter(
								new ValueConverter<DateTime, DateTime>(
										v => v.Kind == DateTimeKind.Utc ? v : DateTime.SpecifyKind(v, DateTimeKind.Utc),
										v => DateTime.SpecifyKind(v, DateTimeKind.Utc)
								)
						);
					}
					else if (property.ClrType == typeof(DateTime?))
					{
						property.SetValueConverter(
								new ValueConverter<DateTime?, DateTime?>(
										v => v.HasValue ? DateTime.SpecifyKind(v.Value, DateTimeKind.Utc) : v,
										v => v.HasValue ? DateTime.SpecifyKind(v.Value, DateTimeKind.Utc) : v
								)
						);
					}
				}
			}

			base.OnModelCreating(modelBuilder);

			// Configure Enum to String conversions
			modelBuilder.Entity<User>()
					.Property(u => u.Role)
					.HasConversion<string>();

			modelBuilder.Entity<Employee>()
					.Property(e => e.Gender)
					.HasConversion<string>();

			modelBuilder.Entity<Employee>()
					.Property(e => e.Position)
					.HasConversion<string>();

			modelBuilder.Entity<Employee>()
					.Property(e => e.Status)
					.HasConversion<string>();

			modelBuilder.Entity<Device>()
					.Property(d => d.Type)
					.HasConversion<string>();

			modelBuilder.Entity<Device>()
					.Property(d => d.Status)
					.HasConversion<string>();

			modelBuilder.Entity<Schedule>()
					.Property(s => s.Status)
					.HasConversion<string>();

			modelBuilder.Entity<AttendanceRaw>()
					.Property(a => a.CheckType)
					.HasConversion<string>();

			modelBuilder.Entity<AttendanceRequest>()
					.Property(a => a.RequestType)
					.HasConversion<string>();

			modelBuilder.Entity<AttendanceRequest>()
					.Property(a => a.Status)
					.HasConversion<string>();

			modelBuilder.Entity<ApprovalStep>()
					.Property(a => a.Status)
					.HasConversion<string>();

			modelBuilder.Entity<Certificate>()
					.Property(c => c.CertificateType)
					.HasConversion<string>();

			modelBuilder.Entity<Certificate>()
					.Property(c => c.Status)
					.HasConversion<string>();

			modelBuilder.Entity<EmploymentContract>()
					.Property(e => e.ContractType)
					.HasConversion<string>();

			modelBuilder.Entity<EmploymentContract>()
					.Property(e => e.Status)
					.HasConversion<string>();

			modelBuilder.Entity<AuditLog>()
					.Property(a => a.Action)
					.HasConversion<string>();

			// ==================== RELATIONSHIPS ====================

			// Branch (1) - (n) User
			modelBuilder.Entity<Branch>()
					.HasMany(b => b.Users)
					.WithOne(u => u.Branch)
					.HasForeignKey(u => u.BranchId)
					.OnDelete(DeleteBehavior.Cascade);

			// Branch (1) - (n) Room
			modelBuilder.Entity<Branch>()
					.HasMany(b => b.Rooms)
					.WithOne(r => r.Branch)
					.HasForeignKey(r => r.BranchId)
					.OnDelete(DeleteBehavior.Cascade);

			// Branch (1) - (n) WorkLocation
			modelBuilder.Entity<Branch>()
					.HasMany(b => b.WorkLocations)
					.WithOne(w => w.Branch)
					.HasForeignKey(w => w.BranchId)
					.OnDelete(DeleteBehavior.Cascade);

			// Branch (1) - (n) Shift
			modelBuilder.Entity<Branch>()
					.HasMany(b => b.Shifts)
					.WithOne(s => s.Branch)
					.HasForeignKey(s => s.BranchId)
					.OnDelete(DeleteBehavior.Cascade);

			// Branch (1) - (n) Schedule
			modelBuilder.Entity<Branch>()
					.HasMany(b => b.Schedules)
					.WithOne(s => s.Branch)
					.HasForeignKey(s => s.BranchId)
					.OnDelete(DeleteBehavior.Cascade);

			// Branch (1) - (n) AttendanceDaily
			modelBuilder.Entity<Branch>()
					.HasMany(b => b.AttendanceDailies)
					.WithOne(a => a.Branch)
					.HasForeignKey(a => a.BranchId)
					.OnDelete(DeleteBehavior.Cascade);

			// Branch (1) - (n) AttendanceMonthly
			modelBuilder.Entity<Branch>()
					.HasMany(b => b.AttendanceMonthlies)
					.WithOne(a => a.Branch)
					.HasForeignKey(a => a.BranchId)
					.OnDelete(DeleteBehavior.Cascade);

			// User (1) - (1) Employee
			modelBuilder.Entity<User>()
					.HasOne(u => u.Employee)
					.WithOne(e => e.User)
					.HasForeignKey<Employee>(e => e.UserId)
					.OnDelete(DeleteBehavior.Cascade);

			// User (1) - (n) Schedule (as assigned user)
			modelBuilder.Entity<User>()
					.HasMany(u => u.Schedules)
					.WithOne(s => s.User)
					.HasForeignKey(s => s.UserId)
					.OnDelete(DeleteBehavior.Cascade);

			// User (1) - (n) Schedule (as creator)
			modelBuilder.Entity<User>()
					.HasMany(u => u.CreatedSchedules)
					.WithOne(s => s.CreatedByUser)
					.HasForeignKey(s => s.CreatedByUserId)
					.OnDelete(DeleteBehavior.Restrict);

			// User (1) - (n) AttendanceRaw
			modelBuilder.Entity<User>()
					.HasMany(u => u.AttendanceRaws)
					.WithOne(a => a.User)
					.HasForeignKey(a => a.UserId)
					.OnDelete(DeleteBehavior.Cascade);

			// User (1) - (n) AttendanceDaily
			modelBuilder.Entity<User>()
					.HasMany(u => u.AttendanceDailies)
					.WithOne(a => a.User)
					.HasForeignKey(a => a.UserId)
					.OnDelete(DeleteBehavior.Cascade);

			// User (1) - (n) AttendanceMonthly
			modelBuilder.Entity<User>()
					.HasMany(u => u.AttendanceMonthlies)
					.WithOne(a => a.User)
					.HasForeignKey(a => a.UserId)
					.OnDelete(DeleteBehavior.Cascade);

			// User (1) - (n) AttendanceRequest
			modelBuilder.Entity<User>()
					.HasMany(u => u.AttendanceRequests)
					.WithOne(a => a.User)
					.HasForeignKey(a => a.UserId)
					.OnDelete(DeleteBehavior.Cascade);

			// User (1) - (n) ApprovalStep (as approver)
			modelBuilder.Entity<User>()
					.HasMany(u => u.ApprovalSteps)
					.WithOne(a => a.ApproverUser)
					.HasForeignKey(a => a.ApproverUserId)
					.OnDelete(DeleteBehavior.Restrict);

			// User (1) - (n) AuditLog
			modelBuilder.Entity<User>()
					.HasMany(u => u.AuditLogs)
					.WithOne(a => a.User)
					.HasForeignKey(a => a.UserId)
					.OnDelete(DeleteBehavior.Cascade);

			// Employee (1) - (n) Certificate
			modelBuilder.Entity<Employee>()
					.HasMany(e => e.Certificates)
					.WithOne(c => c.Employee)
					.HasForeignKey(c => c.EmployeeId)
					.OnDelete(DeleteBehavior.Cascade);

			// Employee (1) - (n) EmploymentContract
			modelBuilder.Entity<Employee>()
					.HasMany(e => e.EmploymentContracts)
					.WithOne(c => c.Employee)
					.HasForeignKey(c => c.EmployeeId)
					.OnDelete(DeleteBehavior.Cascade);

			// Room (1) - (n) Device
			modelBuilder.Entity<Room>()
					.HasMany(r => r.Devices)
					.WithOne(d => d.Room)
					.HasForeignKey(d => d.RoomId)
					.OnDelete(DeleteBehavior.Cascade);

			// WorkLocation (1) - (n) Schedule
			modelBuilder.Entity<WorkLocation>()
					.HasMany(w => w.Schedules)
					.WithOne(s => s.WorkLocation)
					.HasForeignKey(s => s.WorkLocationId)
					.OnDelete(DeleteBehavior.Cascade);

			// Shift (1) - (n) Schedule
			modelBuilder.Entity<Shift>()
					.HasMany(s => s.Schedules)
					.WithOne(sc => sc.Shift)
					.HasForeignKey(sc => sc.ShiftId)
					.OnDelete(DeleteBehavior.Cascade);

			// AttendanceRequest (1) - (n) ApprovalStep
			modelBuilder.Entity<AttendanceRequest>()
					.HasMany(r => r.ApprovalSteps)
					.WithOne(a => a.Request)
					.HasForeignKey(a => a.RequestId)
					.OnDelete(DeleteBehavior.Cascade);

			// Configure indexes for performance
			modelBuilder.Entity<User>()
					.HasIndex(u => u.Username)
					.IsUnique();

			modelBuilder.Entity<User>()
					.HasIndex(u => u.Email)
					.IsUnique();

			modelBuilder.Entity<Employee>()
					.HasIndex(e => e.EmployeeCode)
					.IsUnique();

			modelBuilder.Entity<AttendanceRaw>()
					.HasIndex(a => new { a.UserId, a.CheckTime });

			modelBuilder.Entity<AttendanceDaily>()
					.HasIndex(a => new { a.UserId, a.WorkDate })
					.IsUnique();

			modelBuilder.Entity<AttendanceMonthly>()
					.HasIndex(a => new { a.UserId, a.Month, a.Year })
					.IsUnique();

			modelBuilder.Entity<Schedule>()
					.HasIndex(s => new { s.UserId, s.WorkDate });

			modelBuilder.Entity<AuditLog>()
					.HasIndex(a => new { a.UserId, a.CreatedTime });
		}

		public override Task<int> SaveChangesAsync(
			CancellationToken cancellationToken = default)
		{
			var utcNow = DateTime.UtcNow;

			foreach (var entry in ChangeTracker.Entries<BaseEntity>())
			{
				switch (entry.State)
				{
					case EntityState.Added:
						entry.Entity.CreatedTime = utcNow;
						entry.Entity.LastUpdatedTime = utcNow;
						break;

					case EntityState.Modified:
						entry.Entity.LastUpdatedTime = utcNow;
						break;

					case EntityState.Deleted:
						entry.State = EntityState.Modified;
						entry.Entity.DeletedTime = utcNow;
						break;
				}
			}

			return base.SaveChangesAsync(cancellationToken);
		}


		protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
		{
			configurationBuilder.Properties<DateTime>()
					.HaveConversion<UtcPreserveConverter>();
		}

		private class UtcPreserveConverter : ValueConverter<DateTime, DateTime>
		{
			public UtcPreserveConverter() : base(
					v => DateTime.SpecifyKind(v, DateTimeKind.Utc),
					v => DateTime.SpecifyKind(v.ToUniversalTime(), DateTimeKind.Unspecified)
			)
			{ }
		}
	}
}
