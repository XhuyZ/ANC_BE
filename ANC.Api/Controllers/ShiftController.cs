using Microsoft.AspNetCore.Mvc;

namespace ANC.Api.Controllers
{
	[Route("api/shifts")]
	[ApiController]
	public class ShiftController : ControllerBase
	{
		/// <summary>
		/// Get all shifts by branch
		/// </summary>
		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			return Ok();
		}

		/// <summary>
		/// Get shift by id
		/// </summary>
		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(Guid id)
		{
			return Ok();
		}

		/// <summary>
		/// Create new shift
		/// </summary>
		[HttpPost]
		public async Task<IActionResult> Create()
		{
			return Ok();
		}

		/// <summary>
		/// Update shift
		/// </summary>
		[HttpPut("{id}")]
		public async Task<IActionResult> Update(Guid id)
		{
			return Ok();
		}

		/// <summary>
		/// Delete shift
		/// </summary>
		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(Guid id)
		{
			return Ok();
		}
	}
}

