namespace ANC.Domain.Models.Shift
{
	// Create
	public class ShiftModifyModel
	{
		public Guid BranchId { get; set; }
		public string Name { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public int Break { get; set; }
	}
}
