using ANC.Domain.Bases;

namespace ANC.Domain.Entities
{
	public class WorkLocation : BaseEntity
	{
		public Guid BranchId { get; set; }
		public string Name { get; set; }
		public string Department { get; set; }
		public bool IsActive { get; set; }

		// Navigation properties
		public virtual Branch Branch { get; set; }
		public virtual ICollection<Schedule> Schedules { get; set; }
	}
}
