using RecruitmentAgency.Core.Entities;
using System;
using System.Collections.Generic;

namespace RecruitmentAgency.Core.Managers
{
    public interface IVacancyManager : IManager<Vacancy, int>
    {
        ICollection<Vacancy> GetAllForEmployee(int id);

        ICollection<Vacancy> GetAllActive();

        ICollection<Vacancy> Search(Func<Vacancy, bool> search);

        void SwitchActive(int id);
    }
}
