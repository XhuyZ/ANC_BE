using ANC.Domain.Constant;
using ANC.Domain.Models.ApprovalStep;

namespace ANC.Domain.Models.AttendanceRequest
{

	// Create
	public class CreateAttendanceRequestModel
	{
		public Guid UserId { get; set; }
		public RequestType RequestType { get; set; }
		public DateTime TargetDate { get; set; }
		public string Reason { get; set; }
	}

	// Update
	public class UpdateAttendanceRequestModel
	{
		public Guid Id { get; set; }
		public RequestType RequestType { get; set; }
		public DateTime TargetDate { get; set; }
		public string Reason { get; set; }
	}

	// Approve/Reject
	public class ProcessAttendanceRequestModel
	{
		public Guid RequestId { get; set; }
		public Guid ApproverUserId { get; set; }
		public ApprovalStatus Status { get; set; }
		public string Comment { get; set; }
	}

	// Response
	public class AttendanceRequestResponseModel
	{
		public Guid Id { get; set; }
		public Guid UserId { get; set; }
		public string Username { get; set; }
		public string EmployeeName { get; set; }
		public RequestType RequestType { get; set; }
		public DateTime TargetDate { get; set; }
		public string Reason { get; set; }
		public RequestStatus Status { get; set; }
		public List<ApprovalStepResponseModel> ApprovalSteps { get; set; }
		public DateTime? CreatedTime { get; set; }
		public DateTime? LastUpdatedTime { get; set; }
	}
}
