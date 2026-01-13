using ANC.Domain.Bases;
using ANC.Domain.Constant;

namespace ANC.Domain.Entities
{
	public class Employee : BaseEntity
	{
		public Guid UserId { get; set; }
		public string EmployeeCode { get; set; }
		public string FullName { get; set; }
		public DateTime Dob { get; set; }
		public Gender Gender { get; set; }
		public Position Position { get; set; }
		public EmployeeStatus Status { get; set; }

		// Navigation properties
		public virtual User User { get; set; }
		public virtual ICollection<Certificate> Certificates { get; set; }
		public virtual ICollection<EmploymentContract> EmploymentContracts { get; set; }
	}
}

