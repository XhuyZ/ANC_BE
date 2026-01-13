namespace ANC.Domain.Models.Room
{
	public class RoomModifyModel
	{
		public Guid Id { get; set; }
		public Guid BranchId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool IsActive { get; set; }
	}

}
