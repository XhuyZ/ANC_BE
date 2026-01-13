using ANC.Domain.Constant;

namespace ANC.Domain.Models.Schedule
{
	public class ScheduleViewModel
	{
		public Guid Id { get; set; }
		public Guid UserId { get; set; }
		public string Username { get; set; }
		public string EmployeeName { get; set; }
		public Guid BranchId { get; set; }
		public string BranchName { get; set; }
		public Guid WorkLocationId { get; set; }
		public string WorkLocationName { get; set; }
		public Guid ShiftId { get; set; }
		public string ShiftName { get; set; }
		public DateTime WorkDate { get; set; }
		public ScheduleStatus Status { get; set; }
		public Guid CreatedByUserId { get; set; }
		public string CreatedByUsername { get; set; }
		public DateTime? CreatedTime { get; set; }
		public DateTime? LastUpdatedTime { get; set; }
	}
}

