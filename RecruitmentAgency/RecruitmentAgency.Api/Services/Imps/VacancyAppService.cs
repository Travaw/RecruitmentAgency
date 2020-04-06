using AutoMapper;
using System.Collections.Generic;

using RecruitmentAgency.Api.Services.DTOs;
using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Managers;
using System;
using RecruitmentAgency.Api.Helpers;
using System.Linq.Expressions;
using System.Linq;

namespace RecruitmentAgency.Api.Services.Imps
{
    public class VacancyAppService : IVacancyAppService
    {
        private readonly IVacancyManager vacancyManager;

        private readonly IEmployeeManager employeeManager;

        private readonly IMapper mapper;

        public VacancyAppService(IVacancyManager vacancyManager, IEmployeeManager employeeManager, IMapper mapper)
        {
            this.vacancyManager = vacancyManager;
            this.employeeManager = employeeManager;
            this.mapper = mapper;
        }

        public VacancyDTO Create(CreateVacancyDTO createVacancyDTO)
        {
            var vacancy = mapper.Map<Vacancy>(createVacancyDTO);
            vacancy.CreationDate = DateTime.Now;
            vacancy.IsActive = true;
            vacancy.Employee = employeeManager.Get(e=>e.User.Login==createVacancyDTO.UserName);
            var entity = vacancyManager.Create(vacancy);
            return mapper.Map<VacancyDTO>(entity);
        }

        public VacancyDTO Update(UpdateVacancyDTO updateVacancyDTO)
        {/*
            var vacancy = vacancyManager.Get(updateVacancyDTO.Id); //mapper.Map<Vacancy>(updateVacancyDTO);
            vacancy.Description = updateVacancyDTO.Description;
            vacancy.Requierements = updateVacancyDTO.Requierements;
            vacancy.Description = updateVacancyDTO.Description;
            var entity = vacancyManager.Update(user);
            return mapper.Map<VacancyDTO>(entity);*/
            return new VacancyDTO();
        }


        public VacancyDTO Get(int id)
        {
            var entity = vacancyManager.Get(id);
            return mapper.Map<VacancyDTO>(entity);
        }

        public ICollection<VacancyDTO> GetAll()
        {
            return mapper.Map<ICollection<VacancyDTO>>(vacancyManager.GetAll());
        }

        public ICollection<VacancyDTO> GetAllActive()
        {
            return mapper.Map<ICollection<VacancyDTO>>(vacancyManager.GetAllActive());
        }

        public ICollection<VacancyDTO> GetAllForUser(string userName)
        {
            var user = employeeManager.Get(e => e.User.Login == userName);
            var vacancies = vacancyManager.GetAllForEmployee(user.Id);
            return mapper.Map<ICollection<VacancyDTO>>(vacancies);
        }

        public ICollection<VacancyDTO> Search(SearchVacancyDTO search)
        {
            Expression<Func<Vacancy, bool>> searchFunc = RequestHelper.CreateVacancyLambda(search.Name, search.Experience, search.ProfessionalField, search.Description,search.Requierements, search.Salary);
            if (searchFunc == null)
            {
                return mapper.Map<ICollection<VacancyDTO>>(vacancyManager.GetAll());
            }
            else
            {
                return mapper.Map<ICollection<VacancyDTO>>(vacancyManager.Search(searchFunc.Compile()));
            }
        }

        public void SwitchActive(int id)
        {
            vacancyManager.SwitchActive(id);
        }

        public void Delete(int id)
        {
            vacancyManager.Delete(id);
        }
    }
}
