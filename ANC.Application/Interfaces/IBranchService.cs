using ANC.Domain.Models.Branch;
using Microsoft.AspNetCore.Http;

namespace ANC.Application.Interfaces
{
	public interface IBranchService
	{

		Task<List<BranchViewModel>> GetAllBranch();
	}
}

