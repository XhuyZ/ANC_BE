namespace ANC.Domain.Models.WorkLocation
{
	public class WorkLocationModifyModel
	{
		public Guid BranchId { get; set; }
		public string Name { get; set; }
		public string Department { get; set; }
		public bool IsActive { get; set; } = true;
	}

	// Response
}
