using NHibernate;
using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Repositories;

namespace RecruitmentAgency.NHibernate.Repositories
{
    public class UserRepository : NHRepository<User, int>, IUserRepository
    {
        public UserRepository(ISession session) : base(session)
        {

        }
    }
}
