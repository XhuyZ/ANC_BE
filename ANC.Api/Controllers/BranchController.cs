using ANC.Application.Interfaces;
using ANC.Domain.Bases;
using ANC.Domain.Models.Branch;
using Microsoft.AspNetCore.Mvc;

namespace ANC.Api.Controllers
{
	[Route("api/branches")]
	[ApiController]
	public class BranchController : ControllerBase
	{

		private readonly IBranchService _branchService;
		// private readonly IEventPublisher _eventPublisher;

		public BranchController(IBranchService branchService)
		{
			_branchService = branchService;
			// _eventPublisher = eventPublisher;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllBranch()
		{
			var response = await _branchService.GetAllBranch();
			return Ok(BaseResponse<List<BranchViewModel>>.OkDataResponse(response, "Get List Branches Successfully"));
		}
		[HttpPost]
		public async Task<IActionResult> Create([FromBody] BranchModifyModel request)
		{
			var result = await _branchService.CreateBranch(request);
			return Ok(BaseResponse<BranchViewModel>
					.OkDataResponse(result, "Create branch successfully"));
		}
		/// <summary>
		/// Update branch
		/// </summary>
		[HttpPut("{id}")]
		public async Task<IActionResult> Update(Guid id, [FromBody] BranchModifyModel request)
		{
			// var result = await _branchService.UpdateBranch(id, request);
			return Ok();
		}

		/// <summary>
		/// Soft delete branch
		/// </summary>
		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(Guid id)
		{
			// await _branchService.DeleteBranch(id);
			return Ok();
		}

		/// <summary>
		/// Activate branch
		/// </summary>
		[HttpPatch("{id}/activate")]
		public async Task<IActionResult> Activate(Guid id)
		{
			// await _branchService.ActivateBranch(id);
			return Ok();
		}

		/// <summary>
		/// Deactivate branch
		/// </summary>
		[HttpPatch("{id}/deactivate")]
		public async Task<IActionResult> Deactivate(Guid id)
		{
			// await _branchService.DeactivateBranch(id);
			return Ok();
		}

		/// <summary>
		/// Get all rooms of a branch
		/// </summary>
		[HttpGet("{id}/rooms")]
		public async Task<IActionResult> GetRooms(Guid id)
		{
			// var result = await _branchService.GetRooms(id);
			return Ok();
		}

		/// <summary>
		/// Get all devices of a branch
		/// </summary>
		[HttpGet("{id}/devices")]
		public async Task<IActionResult> GetDevices(Guid id)
		{
			// var result = await _branchService.GetDevices(id);
			return Ok();
		}

		/// <summary>
		/// Get all users of a branch
		/// </summary>
		[HttpGet("{id}/users")]
		public async Task<IActionResult> GetUsers(Guid id)
		{
			// var result = await _branchService.GetUsers(id);
			return Ok();
		}

		/// <summary>
		/// Get branch summary dashboard
		/// </summary>
		[HttpGet("{id}/summary")]
		public async Task<IActionResult> GetSummary(Guid id)
		{
			// var result = await _branchService.GetBranchSummary(id);
			return Ok();
		}

	}
}

