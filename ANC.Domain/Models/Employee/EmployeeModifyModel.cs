using ANC.Domain.Constant;

namespace ANC.Domain.Models.Employee
{
	public class EmployeeModifyModel
	{
		public string EmployeeCode { get; set; }
		public string FullName { get; set; }
		public DateTime Dob { get; set; }
		public Gender Gender { get; set; }
		public Position Position { get; set; }
		public EmployeeStatus Status { get; set; }
	}
	// Create
}

