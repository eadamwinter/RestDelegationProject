using AutoMapper;
using RestDelegations.Helpers;

namespace RestDelegations.Profiles
{
    public class EmployeesProfile : Profile
    {
        public EmployeesProfile()
        {
            CreateMap<Entities.Employee, Models.EmployeeGetDto>();
            CreateMap<Entities.Employee, Models.EmployeeExtGetDto>()
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.GetYearDifference()))
                .ForMember(dest => dest.WorkingTime, opt => opt.MapFrom(src => src.DateOfEmployment.GetYearDifference()))
                .ForMember(dest => dest.PeriodOfNotice, opt => opt.MapFrom(src => src.DateOfEmployment.GetPeriodOfNotice()));

            CreateMap<Models.EmployeeCreateDto, Entities.Employee>();
        }
    }
}
