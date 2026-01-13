using ANC.Domain.Bases;
using ANC.Domain.Constant;

namespace ANC.Domain.Entities
{
	public class AttendanceRequest : BaseEntity
	{
		public Guid UserId { get; set; }
		public RequestType RequestType { get; set; }
		public DateTime TargetDate { get; set; }
		public string Reason { get; set; }
		public RequestStatus Status { get; set; }

		// Navigation properties
		public virtual User User { get; set; }
		public virtual ICollection<ApprovalStep> ApprovalSteps { get; set; }
	}
}

