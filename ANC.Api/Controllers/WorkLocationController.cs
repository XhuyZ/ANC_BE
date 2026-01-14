using Microsoft.AspNetCore.Mvc;

namespace ANC.Api.Controllers
{
	[Route("api/work-locations")]
	[ApiController]
	public class WorkLocationController : ControllerBase
	{
		/// <summary>
		/// Get all work locations by branch
		/// </summary>
		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			return Ok();
		}

		/// <summary>
		/// Get work location by id
		/// </summary>
		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(Guid id)
		{
			return Ok();
		}

		/// <summary>
		/// Create new work location
		/// </summary>
		[HttpPost]
		public async Task<IActionResult> Create()
		{
			return Ok();
		}

		/// <summary>
		/// Update work location
		/// </summary>
		[HttpPut("{id}")]
		public async Task<IActionResult> Update(Guid id)
		{
			return Ok();
		}

		/// <summary>
		/// Activate work location
		/// </summary>
		[HttpPatch("{id}/activate")]
		public async Task<IActionResult> Activate(Guid id)
		{
			return Ok();
		}

		/// <summary>
		/// Deactivate work location
		/// </summary>
		[HttpPatch("{id}/deactivate")]
		public async Task<IActionResult> Deactivate(Guid id)
		{
			return Ok();
		}
	}
}

