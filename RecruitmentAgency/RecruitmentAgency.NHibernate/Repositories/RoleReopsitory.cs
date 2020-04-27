using NHibernate;
using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Repositories;
using System.Linq;

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

        /// <inheritdoc/>
        public override IQueryable<Role> GetAll()
        {
            return session.Query<Role>().Select(r => new Role() { Id = r.Id, Name = r.Name });
        }
    }
}
