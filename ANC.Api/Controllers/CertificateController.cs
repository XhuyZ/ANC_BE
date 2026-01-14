using Microsoft.AspNetCore.Mvc;

namespace ANC.Api.Controllers
{
	[Route("api/certificates")]
	[ApiController]
	public class CertificateController : ControllerBase
	{
		/// <summary>
		/// Get certificates by employee
		/// </summary>
		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			return Ok();
		}

		/// <summary>
		/// Get certificate by id
		/// </summary>
		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(Guid id)
		{
			return Ok();
		}

		/// <summary>
		/// Create professional certificate
		/// </summary>
		[HttpPost]
		public async Task<IActionResult> Create()
		{
			return Ok();
		}

		/// <summary>
		/// Update professional certificate
		/// </summary>
		[HttpPut("{id}")]
		public async Task<IActionResult> Update(Guid id)
		{
			return Ok();
		}

		/// <summary>
		/// Mark certificate as expired
		/// </summary>
		[HttpPatch("{id}/expire")]
		public async Task<IActionResult> Expire(Guid id)
		{
			return Ok();
		}
	}
}

