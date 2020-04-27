using NHibernate;
using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Repositories;

namespace RecruitmentAgency.NHibernate.Repositories
{
    /// <summary>
    /// Репозиторий сущности <see cref="Role"/>
    /// </summary>
    public class RoleRepository : NHRepository<Role, int>, IRoleRepository
    {
        public RoleRepository(ISession session) : base(session)
        {

        }
    }
}
