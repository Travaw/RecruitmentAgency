using System.Collections.Generic;

using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Domain.Repositories;

namespace RecruitmentAgency.Core.Repositories
{
    /// <summary>
    /// Репозиторий сущности <see cref="Vacancy"/>
    /// </summary>
    public interface IVacancyRepository : IRepository<Vacancy, int>
    {
        /// <summary>
        /// Поиск вакансий
        /// </summary>
        /// <param name="search">Параметры поиска</param>
        /// <returns></returns>
        ICollection<Vacancy> Search(string name, int? experience, string professionalField, string description, string requirements, int? salary, bool isActive);
    }
}
