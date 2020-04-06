using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RecruitmentAgency.Core.Managers.Imps
{
    public class VacancyManager: ManagerBase<IVacancyRepository, Vacancy, int>, IVacancyManager
    {
        public VacancyManager(IVacancyRepository vacancyRepository) : base(vacancyRepository)
        {

        }

        public ICollection<Vacancy> GetAllForEmployee(int id)
        {
            return repository.Search(v => v.Employee.Id==id).ToList();
        }

        public ICollection<Vacancy> Search(Func<Vacancy, bool> predicate)
        {
            return repository.Search(predicate).ToList();
        }

        public ICollection<Vacancy> GetAllActive()
        {
            return repository.Search(v => v.IsActive == true).ToList();
        }
        public void SwitchActive(int id)
        {
            var vacancy = repository.Get(id);
            vacancy.IsActive = !vacancy.IsActive;
            repository.Update(vacancy);
        }
    }
}
