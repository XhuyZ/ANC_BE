using ANC.Domain.Constant;

namespace ANC.Domain.Models.EmploymentContract
{
	public class CreateEmploymentContractRequestModel
	{
		public Guid EmployeeId { get; set; }
		public ContractType ContractType { get; set; }
		public ContractStatus Status { get; set; } = ContractStatus.Pending;
		public string FileUrl { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
	}

	// Update
	public class UpdateEmploymentContractRequestModel
	{
		public Guid Id { get; set; }
		public ContractType ContractType { get; set; }
		public ContractStatus Status { get; set; }
		public string FileUrl { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
	}

	// Response
	public class EmploymentContractResponseModel
	{
		public Guid Id { get; set; }
		public Guid EmployeeId { get; set; }
		public string EmployeeName { get; set; }
		public ContractType ContractType { get; set; }
		public ContractStatus Status { get; set; }
		public string FileUrl { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public DateTime? CreatedTime { get; set; }
		public DateTime? LastUpdatedTime { get; set; }
	}
}
