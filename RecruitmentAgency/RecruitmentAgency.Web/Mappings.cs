using AutoMapper;
using RecruitmentAgency.Api.Services.DTOs;
using RecruitmentAgency.Web.Models;

namespace RecruitmentAgency.Web
{
    public class Mappings : Profile
    {
        public Mappings()
        {            
            //CreateMap<CreateUserDTO, UserCreateModel>();
            CreateMap<UserCreateModel, CreateUserDTO>();
            //CreateMap<CreateCandidateDTO, CandidateCreateModel>();
            CreateMap<CandidateCreateModel, CreateCandidateDTO>().ForMember(dest => dest.Photo, opt => opt.Ignore())
                                                                  .ForMember(dest => dest.UserName, opt => opt.Ignore());
           // CreateMap<CreateEmployeeDTO, EmployeeCreateModel>();
            CreateMap<EmployeeCreateModel, CreateEmployeeDTO>();
            //CreateMap<CreateVacancyDTO, VacancyCreateModel>();
            CreateMap<VacancyCreateModel, CreateVacancyDTO>();
            //CreateMap<UpdateUserDTO, UserEditModel>();
            CreateMap<UserEditModel, UpdateUserDTO>();
            //CreateMap<UpdateCandidateDTO, CandidateEditModel>();
            CreateMap<CandidateEditModel, UpdateCandidateDTO>().ForMember(dest => dest.Photo, opt => opt.Ignore());
           // CreateMap<UpdateEmployeeDTO, EmployeeEditModel>();
            CreateMap<EmployeeEditModel, UpdateEmployeeDTO>();
            //CreateMap<UpdateVacancyDTO, VacancyEditModel>();//.ForMember(dest => dest.Employee, opt => opt.MapFrom(exp => exp.Employee != null ? exp.Executor.Id : (int?)null)); ;
            CreateMap<VacancyEditModel, UpdateVacancyDTO>();

            CreateMap<UserDTO, UserEditModel>();
            //CreateMap<UserModel,UserDTO>();
            CreateMap<CandidateDTO, CandidateEditModel>().ForMember(dest => dest.OldPhoto, opt => opt.MapFrom(c=>c.Photo));
            //CreateMap<CandidateModel, CandidateDTO>();
            CreateMap<EmployeeDTO, EmployeeEditModel>();
            //CreateMap<EmployeeModel, EmployeeDTO>();
            CreateMap<VacancyDTO, VacancyModel>();

            CreateMap<UserDTO, UserModel>();
            //CreateMap<UserModel,UserDTO>();
            CreateMap<CandidateDTO, CandidateModel>();
            //CreateMap<CandidateModel, CandidateDTO>();
            CreateMap<EmployeeDTO, EmployeeModel>();
            //CreateMap<EmployeeModel, EmployeeDTO>();
            CreateMap<VacancyDTO, VacancyModel>();

            CreateMap<VacancySearchModel, SearchVacancyDTO>();

            CreateMap<CandidateSearchModel, SearchCandidateDTO>();
            //CreateMap<VacancyModel, VacancyDTO>();

        }
    }
}