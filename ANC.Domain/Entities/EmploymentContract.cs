using ANC.Domain.Bases;
using ANC.Domain.Constant;

namespace ANC.Domain.Entities
{
	public class EmploymentContract : BaseEntity
	{
		public Guid EmployeeId { get; set; }
		public ContractType ContractType { get; set; }
		public ContractStatus Status { get; set; }
		public string FileUrl { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

		// Navigation properties
		public virtual Employee Employee { get; set; }
	}
}
