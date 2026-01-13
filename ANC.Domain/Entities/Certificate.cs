using ANC.Domain.Bases;
using ANC.Domain.Constant;

namespace ANC.Domain.Entities
{
	public class Certificate : BaseEntity
	{
		public Guid EmployeeId { get; set; }
		public CertificateType CertificateType { get; set; }
		public string CertificateNumber { get; set; }
		public DateTime IssuedDate { get; set; }
		public DateTime ExpiredDate { get; set; }
		public CertificateStatus Status { get; set; }
		public string FileUrl { get; set; }

		// Navigation properties
		public virtual Employee Employee { get; set; }
	}
}
