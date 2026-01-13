using ANC.Domain.Constant;

namespace ANC.Domain.Models.Device
{

	// Response
	public class DeviceViewModel
	{
		public Guid Id { get; set; }
		public Guid RoomId { get; set; }
		public string RoomName { get; set; }
		public string Name { get; set; }
		public DeviceType Type { get; set; }
		public string IpAddress { get; set; }
		public DeviceStatus Status { get; set; }
		public DateTime? LastSyncAt { get; set; }
		public DateTime? CreatedTime { get; set; }
		public DateTime? LastUpdatedTime { get; set; }
	}
}
