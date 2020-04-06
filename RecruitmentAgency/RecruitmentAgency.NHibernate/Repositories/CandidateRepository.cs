using NHibernate;
using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Repositories;

namespace RecruitmentAgency.NHibernate.Repositories
{
    public class CandidateRepository : NHRepository<Candidate, int>, ICandidateRepository
    {
        public CandidateRepository(ISession session): base(session)
        {

        }
    }
}
