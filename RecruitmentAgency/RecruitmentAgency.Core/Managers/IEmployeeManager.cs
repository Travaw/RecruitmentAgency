using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.Core.Managers
{
    public interface IEmployeeManager : IManager<Employee, int>
    {
        Employee GetByUser(string login);
    }
}
