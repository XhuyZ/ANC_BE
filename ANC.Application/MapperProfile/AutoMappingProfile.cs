
using ANC.Domain.Entities;
using ANC.Domain.Models.Branch;
using AutoMapper;


namespace ANC.Application.MapperProfile
{
	public class AutoMappingProfile : Profile
	{
		public AutoMappingProfile()
		{
			CreateMap<Branch, BranchViewModel>();
			CreateMap<BranchModifyModel, Branch>();
		}
	}
}
