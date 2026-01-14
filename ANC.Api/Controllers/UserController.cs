using Microsoft.AspNetCore.Mvc;

namespace ANC.Api.Controllers
{
	[Route("api/users")]
	[ApiController]
	public class UserController : ControllerBase
	{
		/// <summary>
		/// Get all users by branch
		/// </summary>
		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			return Ok();
		}

		/// <summary>
		/// Get user by id
		/// </summary>
		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(Guid id)
		{
			return Ok();
		}

		/// <summary>
		/// Create user account
		/// </summary>
		[HttpPost]
		public async Task<IActionResult> Create()
		{
			return Ok();
		}

		/// <summary>
		/// Update user account
		/// </summary>
		[HttpPut("{id}")]
		public async Task<IActionResult> Update(Guid id)
		{
			return Ok();
		}

		/// <summary>
		/// Reset user password
		/// </summary>
		[HttpPatch("{id}/reset-password")]
		public async Task<IActionResult> ResetPassword(Guid id)
		{
			return Ok();
		}

		/// <summary>
		/// Activate user
		/// </summary>
		[HttpPatch("{id}/activate")]
		public async Task<IActionResult> Activate(Guid id)
		{
			return Ok();
		}

		/// <summary>
		/// Deactivate user
		/// </summary>
		[HttpPatch("{id}/deactivate")]
		public async Task<IActionResult> Deactivate(Guid id)
		{
			return Ok();
		}
	}
}

