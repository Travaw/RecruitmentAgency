using AutoMapper;

using RecruitmentAgency.Api.Services.DTOs;
using RecruitmentAgency.Web.Models;

namespace RecruitmentAgency.Web
{
    /// <summary>
    /// Маппинг
    /// </summary>
    public class Mappings : Profile
    {
        public Mappings()
        {            
            CreateMap<UserCreateModel, CreateUserDTO>();

            CreateMap<CandidateCreateModel, CreateCandidateDTO>().ForMember(dest => dest.Photo, opt => opt.Ignore())
                                                                  .ForMember(dest => dest.UserName, opt => opt.Ignore());
           
            CreateMap<EmployeeCreateModel, CreateEmployeeDTO>();
            
            CreateMap<VacancyCreateModel, CreateVacancyDTO>();

            CreateMap<UserEditModel, UpdateUserDTO>();

            CreateMap<CandidateEditModel, UpdateCandidateDTO>().ForMember(dest => dest.Photo, opt => opt.Ignore());
           
            CreateMap<EmployeeEditModel, UpdateEmployeeDTO>();
           
            CreateMap<VacancyEditModel, UpdateVacancyDTO>();

            CreateMap<UserDTO, UserEditModel>();
            CreateMap<CandidateDTO, CandidateEditModel>().ForMember(dest => dest.OldPhoto, opt => opt.MapFrom(c=>c.Photo));
            
            CreateMap<EmployeeDTO, EmployeeEditModel>();
            
            CreateMap<VacancyDTO, VacancyModel>();

            CreateMap<UserDTO, UserModel>();
           
            CreateMap<CandidateDTO, CandidateModel>();
            
            CreateMap<EmployeeDTO, EmployeeModel>();
            
            CreateMap<VacancyDTO, VacancyModel>();

            CreateMap<VacancySearchModel, SearchVacancyDTO>();

            CreateMap<CandidateSearchModel, SearchCandidateDTO>();
            

        }
    }
}