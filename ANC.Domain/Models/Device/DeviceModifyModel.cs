using ANC.Domain.Constant;

namespace ANC.Domain.Models.Device
{

	public class DeviceModifyModel
	{
		public Guid RoomId { get; set; }
		public string Name { get; set; }
		public DeviceType Type { get; set; }
		public string IpAddress { get; set; }
		public DeviceStatus Status { get; set; } = DeviceStatus.Active;
	}

}

