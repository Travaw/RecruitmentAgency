using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Domain.Repositories;

namespace RecruitmentAgency.Core.Repositories
{
    public interface IUserRepository:IRepository<User, int>
    {
    }
}
