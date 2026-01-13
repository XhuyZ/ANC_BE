namespace ANC.Domain.Models.Room
{
	// Response
	public class RoomViewModel
	{
		public Guid Id { get; set; }
		public Guid BranchId { get; set; }
		public string BranchName { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool IsActive { get; set; }
		public DateTime? CreatedTime { get; set; }
		public DateTime? LastUpdatedTime { get; set; }
	}
}

