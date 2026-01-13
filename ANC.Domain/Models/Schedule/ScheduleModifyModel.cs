using ANC.Domain.Constant;

namespace ANC.Domain.Models.Schedule
{

	// Create
	public class CreateScheduleRequestModel
	{
		public Guid UserId { get; set; }
		public Guid BranchId { get; set; }
		public Guid WorkLocationId { get; set; }
		public Guid ShiftId { get; set; }
		public DateTime WorkDate { get; set; }
		public ScheduleStatus Status { get; set; } = ScheduleStatus.Pending;
	}

	// Bulk Create
	public class CreateBulkScheduleRequestModel
	{
		public List<CreateScheduleRequestModel> Schedules { get; set; }
	}

	// Update
	public class UpdateScheduleRequestModel
	{
		public Guid Id { get; set; }
		public Guid UserId { get; set; }
		public Guid BranchId { get; set; }
		public Guid WorkLocationId { get; set; }
		public Guid ShiftId { get; set; }
		public DateTime WorkDate { get; set; }
		public ScheduleStatus Status { get; set; }
	}
}
