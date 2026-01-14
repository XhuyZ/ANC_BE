using ANC.Application.Interfaces;
using ANC.Domain.Entities;
using ANC.Domain.Models.Branch;
using ANC.Infrastructure.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;

namespace ANC.Application.Services
{
	public class BranchService : IBranchService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;
		private readonly IHttpContextAccessor _httpContextAccessor;
		private readonly IHttpClientFactory _httpClientFactory;

		public BranchService(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor, IHttpClientFactory httpClientFactory)
		{
			_mapper = mapper;
			_unitOfWork = unitOfWork;
			_httpContextAccessor = httpContextAccessor;
			_httpClientFactory = httpClientFactory;
		}
		public async Task<List<BranchViewModel>> GetAllBranch()
		{
			var branchList = await _unitOfWork.GetRepository<Branch>().GetAllByPropertyAsync(includeProperties: "WorkLocations", tracked: false);

			var result = _mapper.Map<List<BranchViewModel>>(branchList);

			return result;
		}
		public async Task<BranchViewModel> CreateBranch(BranchModifyModel request)
		{
			var branch = _mapper.Map<Branch>(request);

			branch.IsActive = true;
			branch.CreatedTime = DateTime.UtcNow;

			await _unitOfWork.GetRepository<Branch>().AddAsync(branch);
			await _unitOfWork.SaveAsync();

			return _mapper.Map<BranchViewModel>(branch);
		}

		// public async Task<BranchViewModel> UpdateBranch(BranchModifyModel request)
		// {
		// 	var repo = _unitOfWork.GetRepository<Branch>();
		//
		// 	var branch = await repo.GetByIdAsync(request.BranchId);
		// 	if (branch == null || branch.IsDeleted)
		// 		throw new Exception("Branch not found");
		//
		// 	_mapper.Map(request, branch);
		// 	branch.UpdatedAt = DateTime.UtcNow;
		//
		// 	repo.Update(branch);
		// 	await _unitOfWork.SaveAsync();
		//
		// 	return _mapper.Map<BranchViewModel>(branch);
		// }
		//
		// public async Task<bool> SoftDeleteBranch(Guid id)
		// {
		// 	var repo = _unitOfWork.GetRepository<Branch>();
		//
		// 	var branch = await repo.GetByIdAsync(id);
		// 	if (branch == null || branch.IsDeleted)
		// 		return false;
		//
		// 	branch.IsDeleted = true;
		// 	branch.UpdatedAt = DateTime.UtcNow;
		//
		// 	repo.Update(branch);
		// 	await _unitOfWork.SaveAsync();
		//
		// 	return true;
		// }
	}
}


