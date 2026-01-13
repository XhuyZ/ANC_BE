using ANC.Domain.Bases;
using System;

namespace ANC.Domain.Entities
{
	public class AttendanceDaily : BaseEntity
	{
		public Guid BranchId { get; set; }
		public Guid UserId { get; set; }
		public DateTime WorkDate { get; set; }
		public DateTimeOffset? FirstCheckin { get; set; }
		public DateTimeOffset? LastCheckout { get; set; }
		public int TotalMinutes { get; set; }
		public int OvertimeMinutes { get; set; }
		public int MissingMinutes { get; set; }

		// Navigation properties
		public virtual Branch Branch { get; set; }
		public virtual User User { get; set; }
	}
}
