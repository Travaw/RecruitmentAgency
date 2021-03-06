﻿using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;

using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Repositories;


namespace RecruitmentAgency.NHibernate.Repositories
{
    /// <summary>
    /// Репозиторий сущности <see cref="Vacancy"/>
    /// </summary>
    public class VacancyRepository:NHRepository<Vacancy, int>, IVacancyRepository
    {
        public VacancyRepository(ISession session) : base(session)
        {
           
        }

        /// <inheritdoc/>
        public ICollection<Vacancy> Search(string name, int? experience, string professionalField, string description, string requirements, int? salary, bool isActive, int? employeeId)
        {
            var request = GetAll();
            if (isActive)
            {
                request = request.Where(v => v.IsActive == true);
            }
            if (employeeId != null)
            {
                request = request.Where(v => v.Employee.Id == employeeId);
            }
            if(name!=null && name!=" ")
            {
                request=request.Where(v=>v.Name==name);
            }
            if (experience != null)
            {
                request = request.Where(v => v.Experience == experience);
            }
            if (professionalField != null && professionalField != " ")
            {
                request = request = request.Where(v => v.ProfessionalField == professionalField);
            }
            if (description != null && description != " ")
            {
                string[] keyWords = description.Trim(new Char[] { ',', '.', '!', '?' }).ToLower().Split(' ');
                foreach (var keyWord in keyWords)
                    request = request.Where(v => v.Description.Contains(keyWord));
            }
            if (requirements != null && requirements != " ")
            {
                string[] keyWords = requirements.Trim(new Char[] { ',', '.', '!', '?' }).ToLower().Split(' ');
                foreach (var keyWord in keyWords)
                    request = request.Where(v => v.Requierements.Contains(keyWord));
            }
            if (salary != null)
            {
                request = request.Where(v => v.SalaryFrom <= salary&&v.SalaryTo >= salary);
            }
            return request.ToList();
        }
    }
}
