namespace ANC.Domain.Models.AttendanceDaily
{
	public class CreateAttendanceDailyRequestModel
	{
		public Guid BranchId { get; set; }
		public Guid UserId { get; set; }
		public DateTime WorkDate { get; set; }
		public DateTimeOffset? FirstCheckin { get; set; }
		public DateTimeOffset? LastCheckout { get; set; }
		public int TotalMinutes { get; set; }
		public int OvertimeMinutes { get; set; }
		public int MissingMinutes { get; set; }
	}

	// Update
	public class UpdateAttendanceDailyRequestModel
	{
		public Guid Id { get; set; }
		public DateTimeOffset? FirstCheckin { get; set; }
		public DateTimeOffset? LastCheckout { get; set; }
		public int TotalMinutes { get; set; }
		public int OvertimeMinutes { get; set; }
		public int MissingMinutes { get; set; }
	}

	// Query
	public class GetAttendanceDailyQueryModel
	{
		public Guid? BranchId { get; set; }
		public Guid? UserId { get; set; }
		public DateTime? FromDate { get; set; }
		public DateTime? ToDate { get; set; }
	}

	// Response
	public class AttendanceDailyResponseModel
	{
		public Guid Id { get; set; }
		public Guid BranchId { get; set; }
		public string BranchName { get; set; }
		public Guid UserId { get; set; }
		public string Username { get; set; }
		public string EmployeeName { get; set; }
		public DateTime WorkDate { get; set; }
		public DateTimeOffset? FirstCheckin { get; set; }
		public DateTimeOffset? LastCheckout { get; set; }
		public int TotalMinutes { get; set; }
		public int OvertimeMinutes { get; set; }
		public int MissingMinutes { get; set; }
		public DateTime? CreatedTime { get; set; }
		public DateTime? LastUpdatedTime { get; set; }
	}
}
