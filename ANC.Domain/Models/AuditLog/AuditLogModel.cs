using ANC.Domain.Constant;

namespace ANC.Domain.Models.AuditLog
{
	public class CreateAuditLogRequestModel
	{
		public Guid UserId { get; set; }
		public AuditAction Action { get; set; }
		public string BeforeData { get; set; }
		public string AfterData { get; set; }
	}

	// Query
	public class GetAuditLogQueryModel
	{
		public Guid? UserId { get; set; }
		public AuditAction? Action { get; set; }
		public DateTime? FromDate { get; set; }
		public DateTime? ToDate { get; set; }
	}

	// Response
	public class AuditLogResponseModel
	{
		public Guid Id { get; set; }
		public Guid UserId { get; set; }
		public string Username { get; set; }
		public AuditAction Action { get; set; }
		public string BeforeData { get; set; }
		public string AfterData { get; set; }
		public DateTime? CreatedTime { get; set; }
	}
}
