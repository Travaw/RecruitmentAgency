using NHibernate;
using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Repositories;

namespace RecruitmentAgency.NHibernate.Repositories
{
    public class VacancyRepository:NHRepository<Vacancy, int>, IVacancyRepository
    {
        public VacancyRepository(ISession session) : base(session)
        {

        }
    }
}
