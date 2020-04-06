using AutoMapper;
using RecruitmentAgency.Core.Entities;
using System;

namespace RecruitmentAgency.Api.Services.DTOs
{

    public class Mappings : Profile
        {
            public Mappings()
            {
                CreateMap<User, UserDTO>();//.ForMember(dest => dest.Role, opt => opt.MapFrom(u=>u.Role));
                CreateMap<CreateUserDTO, User>().ForMember(dest => dest.Role, opt => opt.Ignore());
                CreateMap<UpdateUserDTO, User>().ForMember(dest => dest.Role, opt => opt.Ignore()); ;
                CreateMap<Vacancy, VacancyDTO>();
                CreateMap<CreateVacancyDTO, Vacancy>().ForMember(dest => dest.Employee, opt => opt.Ignore());
                CreateMap<UpdateVacancyDTO, Vacancy>().ForMember(dest => dest.Employee, opt => opt.Ignore());
                CreateMap<Employee, EmployeeDTO>();
                CreateMap<CreateEmployeeDTO, Employee>().ForMember(dest => dest.User, opt => opt.Ignore());
                CreateMap<UpdateEmployeeDTO, Employee>().ForMember(dest => dest.User, opt => opt.Ignore());
                CreateMap<Candidate, CandidateDTO>();
                CreateMap<CreateCandidateDTO, Candidate>().ForMember(dest => dest.User, opt => opt.Ignore())
                                                          .ForMember(dest =>dest.Photo, opt=>opt.MapFrom(c=>Convert.ToBase64String(c.Photo)));
                CreateMap<UpdateCandidateDTO, Candidate>().ForMember(dest => dest.User, opt => opt.Ignore());
                CreateMap<Role, RoleDTO>();

            }
        }
    
}
