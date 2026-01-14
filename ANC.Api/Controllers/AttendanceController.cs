using Microsoft.AspNetCore.Mvc;

namespace ANC.Api.Controllers
{
	[Route("api/attendance")]
	[ApiController]
	public class AttendanceController : ControllerBase
	{
		/// <summary>
		/// Import attendance from Excel
		/// </summary>
		[HttpPost("import")]
		public async Task<IActionResult> Import()
		{
			return Ok();
		}

		/// <summary>
		/// Get raw attendance logs
		/// </summary>
		[HttpGet("raw")]
		public async Task<IActionResult> GetRaw()
		{
			return Ok();
		}

		/// <summary>
		/// Get daily attendance
		/// </summary>
		[HttpGet("daily")]
		public async Task<IActionResult> GetDaily()
		{
			return Ok();
		}

		/// <summary>
		/// Get monthly attendance
		/// </summary>
		[HttpGet("monthly")]
		public async Task<IActionResult> GetMonthly()
		{
			return Ok();
		}

		/// <summary>
		/// Lock attendance month
		/// </summary>
		[HttpPatch("monthly/lock")]
		public async Task<IActionResult> LockMonth()
		{
			return Ok();
		}

		/// <summary>
		/// Create attendance adjustment request
		/// </summary>
		[HttpPost("requests")]
		public async Task<IActionResult> CreateRequest()
		{
			return Ok();
		}

		/// <summary>
		/// Approve attendance request
		/// </summary>
		[HttpPatch("requests/{id}/approve")]
		public async Task<IActionResult> ApproveRequest(Guid id)
		{
			return Ok();
		}

		/// <summary>
		/// Reject attendance request
		/// </summary>
		[HttpPatch("requests/{id}/reject")]
		public async Task<IActionResult> RejectRequest(Guid id)
		{
			return Ok();
		}
	}
}

