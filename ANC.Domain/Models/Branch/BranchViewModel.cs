namespace ANC.Domain.Models.Branch
{
	// Create
	public class BranchViewModel
	{
		public string Name { get; set; }
		public string Address { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public bool IsActive { get; set; } = true;
	}
}
