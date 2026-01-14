using ANC.Domain.Models.Branch;
using Microsoft.AspNetCore.Http;

namespace ANC.Application.Interfaces
{
	public interface IBranchService
	{

		Task<List<BranchViewModel>> GetAllBranch();
		Task<BranchViewModel> CreateBranch(BranchModifyModel request);
		// Task<BranchViewModel> UpdateBranch(BranchModifyModel request);
		// Task<bool> SoftDeleteBranch(Guid id);
	}
}

