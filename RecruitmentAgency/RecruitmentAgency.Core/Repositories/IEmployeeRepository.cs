using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Domain.Repositories;

namespace RecruitmentAgency.Core.Repositories
{
    public interface IEmployeeRepository: IRepository<Employee, int>
    {

    }
}
