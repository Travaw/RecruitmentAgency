using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using RecruitmentAgency.Api.Helpers;
using RecruitmentAgency.Api.Services.DTOs;
using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Managers;

namespace RecruitmentAgency.Api.Services.Imps
{
    /// <summary>
    /// Сервис для работы с вакансиями
    /// </summary>
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

        /// <inheritdoc/>
        public VacancyDTO Create(CreateVacancyDTO createVacancyDTO)
        {
            var vacancy = mapper.Map<Vacancy>(createVacancyDTO);
            vacancy.CreationDate = DateTime.Now;
            vacancy.IsActive = true;
            vacancy.Employee = employeeManager.Get(e=>e.User.Login==createVacancyDTO.UserName);
            var entity = vacancyManager.Create(vacancy);
            return mapper.Map<VacancyDTO>(entity);
        }

        /// <inheritdoc/>
        public VacancyDTO Update(UpdateVacancyDTO updateVacancyDTO)
        {
            return new VacancyDTO();
        }

        /// <inheritdoc/>
        public VacancyDTO Get(int id)
        {
            var entity = vacancyManager.Get(id);
            return mapper.Map<VacancyDTO>(entity);
        }

        /// <inheritdoc/>
        public ICollection<VacancyDTO> GetAll()
        {
            return mapper.Map<ICollection<VacancyDTO>>(vacancyManager.GetAll());
        }

        /// <inheritdoc/>
        public ICollection<VacancyDTO> GetAllActive()
        {
            return mapper.Map<ICollection<VacancyDTO>>(vacancyManager.GetAllActive());
        }

        /// <inheritdoc/>
        public ICollection<VacancyDTO> GetAllForUser(string userName)
        {
            var user = employeeManager.Get(e => e.User.Login == userName);
            var vacancies = vacancyManager.GetAllForEmployee(user.Id);
            return mapper.Map<ICollection<VacancyDTO>>(vacancies);
        }

        /// <inheritdoc/>
        public ICollection<VacancyDTO> Search(SearchVacancyDTO search)
        {
            /*Expression<Func<Vacancy, bool>> searchFunc = RequestHelper.CreateVacancyLambda(search.Name, search.Experience, search.ProfessionalField, search.Description,search.Requierements, search.Salary);
            if (searchFunc == null)
            {
                return mapper.Map<ICollection<VacancyDTO>>(vacancyManager.GetAll());
            }
            else
            {*/
            return mapper.Map<ICollection<VacancyDTO>>(vacancyManager.Search(search.Name, search.Experience, search.ProfessionalField, search.Description, search.Requierements, search.Salary));///vacancyManager.Search(searchFunc.Compile()));
            /// }
        }

        /// <inheritdoc/>
        public void SetStatus(int id, bool status)
        {
            vacancyManager.SetStatus(id, status);
        }

        /// <inheritdoc/>
        public void Delete(int id)
        {
            vacancyManager.Delete(id);
        }
    }
}
