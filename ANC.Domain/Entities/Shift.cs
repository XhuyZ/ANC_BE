using ANC.Domain.Bases;

namespace ANC.Domain.Entities
{
	public class Shift : BaseEntity
	{
		public Guid BranchId { get; set; }
		public string Name { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public int Break { get; set; } // in minutes

		// Navigation properties
		public virtual Branch Branch { get; set; }
		public virtual ICollection<Schedule> Schedules { get; set; }
	}
}

