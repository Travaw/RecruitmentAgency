using RecruitmentAgency.Domain.Entities;

namespace RecruitmentAgency.Domain.Repositories
{
    /// <summary>
    /// Репозиторий
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности</typeparam>
    public interface IRepository<IEntity> : IRepository<IEntity<int>, int>
    {

    }
}
