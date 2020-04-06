using NHibernate;
using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Repositories;

namespace RecruitmentAgency.NHibernate.Repositories
{
    public class RoleRepository : NHRepository<Role, int>, IRoleRepository
    {
        public RoleRepository(ISession session) : base(session)
        {

        }
    }
}
