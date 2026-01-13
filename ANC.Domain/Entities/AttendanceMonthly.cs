using ANC.Domain.Bases;
using System;

namespace ANC.Domain.Entities
{
	public class AttendanceMonthly : BaseEntity
	{
		public Guid BranchId { get; set; }
		public Guid UserId { get; set; }
		public int Month { get; set; }
		public int Year { get; set; }
		public int TotalDays { get; set; }
		public int TotalMinutes { get; set; }
		public int OvertimeMinutes { get; set; }
		public int MissingMinutes { get; set; }

		// Navigation properties
		public virtual Branch Branch { get; set; }
		public virtual User User { get; set; }
	}
}
