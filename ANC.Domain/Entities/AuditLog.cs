using ANC.Domain.Bases;
using ANC.Domain.Constant;

namespace ANC.Domain.Entities
{
	public class AuditLog : BaseEntity
	{
		public Guid UserId { get; set; }
		public AuditAction Action { get; set; }
		public string BeforeData { get; set; } // JSONB stored as string
		public string AfterData { get; set; } // JSONB stored as string

		// Navigation properties
		public virtual User User { get; set; }
	}
}
