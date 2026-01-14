using Microsoft.AspNetCore.Mvc;

namespace ANC.Api.Controllers
{
	[Route("api/contracts")]
	[ApiController]
	public class ContractController : ControllerBase
	{
		/// <summary>
		/// Get contracts by employee
		/// </summary>
		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			return Ok();
		}

		/// <summary>
		/// Get contract by id
		/// </summary>
		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(Guid id)
		{
			return Ok();
		}

		/// <summary>
		/// Create employment contract
		/// </summary>
		[HttpPost]
		public async Task<IActionResult> Create()
		{
			return Ok();
		}

		/// <summary>
		/// Update employment contract
		/// </summary>
		[HttpPut("{id}")]
		public async Task<IActionResult> Update(Guid id)
		{
			return Ok();
		}

		/// <summary>
		/// Terminate contract
		/// </summary>
		[HttpPatch("{id}/terminate")]
		public async Task<IActionResult> Terminate(Guid id)
		{
			return Ok();
		}
	}
}

