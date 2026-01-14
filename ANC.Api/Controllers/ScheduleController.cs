using Microsoft.AspNetCore.Mvc;

namespace ANC.Api.Controllers
{
	[Route("api/schedules")]
	[ApiController]
	public class ScheduleController : ControllerBase
	{
		/// <summary>
		/// Get schedules by branch & date range
		/// </summary>
		[HttpGet]
		public async Task<IActionResult> GetSchedules()
		{
			return Ok();
		}

		/// <summary>
		/// Create schedule (drag & drop)
		/// </summary>
		[HttpPost]
		public async Task<IActionResult> Create()
		{
			return Ok();
		}

		/// <summary>
		/// Update schedule (change shift / location)
		/// </summary>
		[HttpPut("{id}")]
		public async Task<IActionResult> Update(Guid id)
		{
			return Ok();
		}

		/// <summary>
		/// Approve schedule
		/// </summary>
		[HttpPatch("{id}/approve")]
		public async Task<IActionResult> Approve(Guid id)
		{
			return Ok();
		}

		/// <summary>
		/// Cancel schedule
		/// </summary>
		[HttpPatch("{id}/cancel")]
		public async Task<IActionResult> Cancel(Guid id)
		{
			return Ok();
		}

		/// <summary>
		/// Get schedule history (audit)
		/// </summary>
		[HttpGet("{id}/history")]
		public async Task<IActionResult> GetHistory(Guid id)
		{
			return Ok();
		}
	}
}

