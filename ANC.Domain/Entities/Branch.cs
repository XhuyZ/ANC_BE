using ANC.Domain.Bases;

namespace ANC.Domain.Entities
{
	public class Branch : BaseEntity
	{
		public string Name { get; set; }
		public string Address { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public bool IsActive { get; set; }

		// Navigation properties
		public virtual ICollection<User> Users { get; set; }
		public virtual ICollection<Room> Rooms { get; set; }
		public virtual ICollection<WorkLocation> WorkLocations { get; set; }
		public virtual ICollection<Shift> Shifts { get; set; }
		public virtual ICollection<Schedule> Schedules { get; set; }
		public virtual ICollection<AttendanceDaily> AttendanceDailies { get; set; }
		public virtual ICollection<AttendanceMonthly> AttendanceMonthlies { get; set; }
	}
}
