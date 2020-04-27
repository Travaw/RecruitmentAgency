using NHibernate;
using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Repositories;
using System;
using System.Linq;

namespace RecruitmentAgency.NHibernate.Repositories
{
    /// <summary>
    /// Репозиторий сущности <see cref="User"/>
    /// </summary>
    public class UserRepository : NHRepository<User, int>, IUserRepository
    {
        public UserRepository(ISession session) : base(session)
        {

        }       

        /// <inheritdoc/>
        public override IQueryable<User> GetAll()
        {
            return session.Query<User>().Select(r=> new User() { Id = r.Id, Login=r.Login});
        }

    }
}
