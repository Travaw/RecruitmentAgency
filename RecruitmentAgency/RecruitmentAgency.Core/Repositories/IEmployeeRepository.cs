using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Domain.Repositories;

namespace RecruitmentAgency.Core.Repositories
{
    /// <summary>
    /// Репозиторий сущности <see cref="Employee"/>
    /// </summary>
    public interface IEmployeeRepository: IRepository<Employee, int>
    {

    }
}
