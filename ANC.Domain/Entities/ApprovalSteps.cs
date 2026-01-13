using ANC.Domain.Bases;
using ANC.Domain.Constant;

namespace ANC.Domain.Entities
{
	public class ApprovalStep : BaseEntity
	{
		public Guid RequestId { get; set; }
		public Guid ApproverUserId { get; set; }
		public ApprovalStatus Status { get; set; }
		public string Comment { get; set; }

		// Navigation properties
		public virtual AttendanceRequest Request { get; set; }
		public virtual User ApproverUser { get; set; }
	}
}
