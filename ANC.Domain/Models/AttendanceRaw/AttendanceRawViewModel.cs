using ANC.Domain.Constant;

namespace ANC.Domain.Models.AttendanceRaw
{
	public class CreateAttendanceRawRequestModel
	{
		public Guid UserId { get; set; }
		public Guid? DeviceId { get; set; }
		public DateTimeOffset CheckTime { get; set; }
		public CheckType CheckType { get; set; }
	}

	// Bulk Create
	public class CreateBulkAttendanceRawRequestModel
	{
		public List<CreateAttendanceRawRequestModel> Attendances { get; set; }
	}

	// Response
	public class AttendanceRawViewModel
	{
		public Guid Id { get; set; }
		public Guid UserId { get; set; }
		public string Username { get; set; }
		public string EmployeeName { get; set; }
		public Guid? DeviceId { get; set; }
		public string DeviceName { get; set; }
		public DateTimeOffset CheckTime { get; set; }
		public CheckType CheckType { get; set; }
		public DateTime? CreatedTime { get; set; }
	}
}

