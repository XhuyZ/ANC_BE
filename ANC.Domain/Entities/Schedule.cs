using ANC.Domain.Bases;
using ANC.Domain.Constant;

namespace ANC.Domain.Entities
{
	public class Schedule : BaseEntity
	{
		public Guid UserId { get; set; }
		public Guid BranchId { get; set; }
		public Guid WorkLocationId { get; set; }
		public Guid ShiftId { get; set; }
		public Guid CreatedByUserId { get; set; }
		public DateTime WorkDate { get; set; }
		public ScheduleStatus Status { get; set; }

		// Navigation properties
		public virtual User User { get; set; }
		public virtual Branch Branch { get; set; }
		public virtual WorkLocation WorkLocation { get; set; }
		public virtual Shift Shift { get; set; }
		public virtual User CreatedByUser { get; set; }
	}
}
