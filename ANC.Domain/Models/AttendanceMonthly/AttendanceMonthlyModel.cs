namespace ANC.Domain.Models.AttendanceMonthly
{
	public class CreateAttendanceMonthlyRequestModel
	{
		public Guid BranchId { get; set; }
		public Guid UserId { get; set; }
		public int Month { get; set; }
		public int Year { get; set; }
		public int TotalDays { get; set; }
		public int TotalMinutes { get; set; }
		public int OvertimeMinutes { get; set; }
		public int MissingMinutes { get; set; }
	}

	// Update
	public class UpdateAttendanceMonthlyRequestModel
	{
		public Guid Id { get; set; }
		public int TotalDays { get; set; }
		public int TotalMinutes { get; set; }
		public int OvertimeMinutes { get; set; }
		public int MissingMinutes { get; set; }
	}

	// Query
	public class GetAttendanceMonthlyQueryModel
	{
		public Guid? BranchId { get; set; }
		public Guid? UserId { get; set; }
		public int? Month { get; set; }
		public int? Year { get; set; }
	}

	// Response
	public class AttendanceMonthlyResponseModel
	{
		public Guid Id { get; set; }
		public Guid BranchId { get; set; }
		public string BranchName { get; set; }
		public Guid UserId { get; set; }
		public string Username { get; set; }
		public string EmployeeName { get; set; }
		public int Month { get; set; }
		public int Year { get; set; }
		public int TotalDays { get; set; }
		public int TotalMinutes { get; set; }
		public int OvertimeMinutes { get; set; }
		public int MissingMinutes { get; set; }
		public DateTime? CreatedTime { get; set; }
		public DateTime? LastUpdatedTime { get; set; }
	}
}

