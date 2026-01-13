using ANC.Domain.Bases;
using ANC.Domain.Constant;

namespace ANC.Domain.Entities
{
	public class Device : BaseEntity
	{
		public Guid RoomId { get; set; }
		public string Name { get; set; }
		public DeviceType Type { get; set; }
		public string IpAddress { get; set; }
		public DeviceStatus Status { get; set; }
		public DateTime? LastSyncAt { get; set; }

		// Navigation properties
		public virtual Room Room { get; set; }
	}
}
