using System;
using System.Collections.Generic;
using System.Linq;

using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Repositories;

namespace RecruitmentAgency.Core.Managers.Imps
{
    /// <summary>
    /// Менеджер сущности <see cref="Vacancy"/>
    /// </summary>
    public class VacancyManager: ManagerBase<IVacancyRepository, Vacancy, int>, IVacancyManager
    {

        private const string entityName = "Vacancy";

        public VacancyManager(IVacancyRepository vacancyRepository) : base(vacancyRepository)
        {

        }

        /// <inheritdoc/>
        public ICollection<Vacancy> GetAllForEmployee(int id)
        {
            return repository.Search(v => v.Employee.Id==id).ToList();
        }

        /// <inheritdoc/>
        public ICollection<Vacancy> Search(Func<Vacancy, bool> predicate)
        {
            return repository.Search(predicate).ToList();
        }

        /// <inheritdoc/>
        public ICollection<Vacancy> Search(string name, int? experience, string professionalField, string description, string requirements, int? salary, bool isActive, int? employeeId)
        {
            return repository.Search(name, experience, professionalField, description, requirements, salary, isActive, employeeId).ToList();
        }

        /// <inheritdoc/>
        public ICollection<Vacancy> GetAllActive()
        {
            return repository.Search(v => v.IsActive == true).ToList();
        }

        /// <inheritdoc/>
        public void SetStatus(int id, bool status)
        {
            var vacancy = repository.Get(id);
            if (vacancy == null)
            {
                throw new EntityNotFoundException(entityName);
            }
            vacancy.IsActive = status;
            repository.Update(vacancy);
        }
    }
}
