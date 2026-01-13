using ANC.Domain.Bases;
using ANC.Domain.Constant;

namespace ANC.Domain.Entities
{
	public class User : BaseEntity
	{
		public Guid BranchId { get; set; }
		public string Username { get; set; }
		public string PasswordHash { get; set; }
		public UserRole Role { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public bool IsActive { get; set; }

		// Navigation properties
		public virtual Branch Branch { get; set; }
		public virtual Employee Employee { get; set; }
		public virtual ICollection<Schedule> Schedules { get; set; }
		public virtual ICollection<Schedule> CreatedSchedules { get; set; }
		public virtual ICollection<AttendanceRaw> AttendanceRaws { get; set; }
		public virtual ICollection<AttendanceDaily> AttendanceDailies { get; set; }
		public virtual ICollection<AttendanceMonthly> AttendanceMonthlies { get; set; }
		public virtual ICollection<AttendanceRequest> AttendanceRequests { get; set; }
		public virtual ICollection<ApprovalStep> ApprovalSteps { get; set; }
		public virtual ICollection<AuditLog> AuditLogs { get; set; }
	}
}

