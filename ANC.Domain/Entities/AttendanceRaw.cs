using ANC.Domain.Bases;
using ANC.Domain.Constant;

namespace ANC.Domain.Entities
{
	public class AttendanceRaw : BaseEntity
	{
		public Guid UserId { get; set; }
		public Guid? DeviceId { get; set; }
		public DateTimeOffset CheckTime { get; set; }
		public CheckType CheckType { get; set; }

		// Navigation properties
		public virtual User User { get; set; }
	}
}
