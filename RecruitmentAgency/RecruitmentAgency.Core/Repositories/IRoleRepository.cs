using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Domain.Repositories;

namespace RecruitmentAgency.Core.Repositories
{
    public interface IRoleRepository:IRepository<Role, int>
    {
    }
}
