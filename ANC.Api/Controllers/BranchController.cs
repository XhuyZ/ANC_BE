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

	}
}

