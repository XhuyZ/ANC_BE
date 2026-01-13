using ANC.Domain.Constant;

namespace ANC.Domain.Models.Certificate
{

	// Create
	public class CreateCertificateRequestModel
	{
		public Guid EmployeeId { get; set; }
		public CertificateType CertificateType { get; set; }
		public string CertificateNumber { get; set; }
		public DateTime IssuedDate { get; set; }
		public DateTime ExpiredDate { get; set; }
		public CertificateStatus Status { get; set; } = CertificateStatus.Valid;
		public string FileUrl { get; set; }
	}

	// Update
	public class UpdateCertificateRequestModel
	{
		public Guid Id { get; set; }
		public CertificateType CertificateType { get; set; }
		public string CertificateNumber { get; set; }
		public DateTime IssuedDate { get; set; }
		public DateTime ExpiredDate { get; set; }
		public CertificateStatus Status { get; set; }
		public string FileUrl { get; set; }
	}

	// Response
	public class CertificateResponseModel
	{
		public Guid Id { get; set; }
		public Guid EmployeeId { get; set; }
		public string EmployeeName { get; set; }
		public CertificateType CertificateType { get; set; }
		public string CertificateNumber { get; set; }
		public DateTime IssuedDate { get; set; }
		public DateTime ExpiredDate { get; set; }
		public CertificateStatus Status { get; set; }
		public string FileUrl { get; set; }
		public DateTime? CreatedTime { get; set; }
		public DateTime? LastUpdatedTime { get; set; }
	}
}

