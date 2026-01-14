using Microsoft.AspNetCore.Mvc;

namespace ANC.Api.Controllers
{
	[Route("api/employees")]
	[ApiController]
	public class EmployeeController : ControllerBase
	{
		/// <summary>
		/// Get all employees
		/// </summary>
		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			return Ok();
		}

		/// <summary>
		/// Get employee by id
		/// </summary>
		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(Guid id)
		{
			return Ok();
		}

		/// <summary>
		/// Create employee
		/// </summary>
		[HttpPost]
		public async Task<IActionResult> Create()
		{
			return Ok();
		}

		/// <summary>
		/// Update employee
		/// </summary>
		[HttpPut("{id}")]
		public async Task<IActionResult> Update(Guid id)
		{
			return Ok();
		}

		/// <summary>
		/// Get employee contracts
		/// </summary>
		[HttpGet("{id}/contracts")]
		public async Task<IActionResult> GetContracts(Guid id)
		{
			return Ok();
		}

		/// <summary>
		/// Get employee certificates
		/// </summary>
		[HttpGet("{id}/certificates")]
		public async Task<IActionResult> GetCertificates(Guid id)
		{
			return Ok();
		}

		/// <summary>
		/// Deactivate employee
		/// </summary>
		[HttpPatch("{id}/deactivate")]
		public async Task<IActionResult> Deactivate(Guid id)
		{
			return Ok();
		}
	}
}

