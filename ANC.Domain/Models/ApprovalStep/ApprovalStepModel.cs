using ANC.Domain.Constant;

namespace ANC.Domain.Models.ApprovalStep
{
	public class CreateApprovalStepRequestModel
	{
		public Guid RequestId { get; set; }
		public Guid ApproverUserId { get; set; }
		public ApprovalStatus Status { get; set; } = ApprovalStatus.Pending;
		public string Comment { get; set; }
	}

	// Update
	public class UpdateApprovalStepRequestModel
	{
		public Guid Id { get; set; }
		public ApprovalStatus Status { get; set; }
		public string Comment { get; set; }
	}

	// Response
	public class ApprovalStepResponseModel
	{
		public Guid Id { get; set; }
		public Guid RequestId { get; set; }
		public Guid ApproverUserId { get; set; }
		public string ApproverUsername { get; set; }
		public string ApproverName { get; set; }
		public ApprovalStatus Status { get; set; }
		public string Comment { get; set; }
		public DateTime? CreatedTime { get; set; }
		public DateTime? LastUpdatedTime { get; set; }
	}
}
