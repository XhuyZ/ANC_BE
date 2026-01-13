namespace ANC.Domain.Models.Shift
{
	public class ShiftViewModel
	{
		public Guid Id { get; set; }
		public Guid BranchId { get; set; }
		public string BranchName { get; set; }
		public string Name { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public int Break { get; set; }
		public DateTime? CreatedTime { get; set; }
		public DateTime? LastUpdatedTime { get; set; }
	}
}

