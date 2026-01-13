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
			var branchList = await _unitOfWork.GetRepository<Branch>().GetAllByPropertyAsync(includeProperties: "", tracked: false);

			var result = _mapper.Map<List<BranchViewModel>>(branchList);

			return result;
		}
	}
}


