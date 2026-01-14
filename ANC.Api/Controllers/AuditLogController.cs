using Microsoft.AspNetCore.Mvc;

namespace ANC.Api.Controllers
{
	[Route("api/audit-logs")]
	[ApiController]
	public class AuditLogController : ControllerBase
	{
		/// <summary>
		/// Get audit logs (filter by entity, user, date)
		/// </summary>
		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			return Ok();
		}

		/// <summary>
		/// Get audit log by id
		/// </summary>
		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(Guid id)
		{
			return Ok();
		}
	}
}

