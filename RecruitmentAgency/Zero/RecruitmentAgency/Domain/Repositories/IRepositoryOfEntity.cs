using RecruitmentAgency.Domain.Entities;

namespace RecruitmentAgency.Domain.Repositories
{
    public interface IRepository<IEntity> : IRepository<IEntity<int>, int>
    {

    }
}
