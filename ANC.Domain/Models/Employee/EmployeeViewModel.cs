using ANC.Domain.Constant;

namespace ANC.Domain.Models.Employee
{

	// Response
	public class EmployeeViewModel
	{
		public Guid Id { get; set; }
		public Guid UserId { get; set; }
		public string Username { get; set; }
		public string EmployeeCode { get; set; }
		public string FullName { get; set; }
		public DateTime Dob { get; set; }
		public Gender Gender { get; set; }
		public Position Position { get; set; }
		public EmployeeStatus Status { get; set; }
		public DateTime? CreatedTime { get; set; }
		public DateTime? LastUpdatedTime { get; set; }
	}
}


