namespace ANC.Domain.Models.WorkLocation
{
	public class WorkLocationViewModel
	{
		public Guid Id { get; set; }
		public Guid BranchId { get; set; }
		public string BranchName { get; set; }
		public string Name { get; set; }
		public string Department { get; set; }
		public bool IsActive { get; set; }
		public DateTime? CreatedTime { get; set; }
		public DateTime? LastUpdatedTime { get; set; }
	}
}

