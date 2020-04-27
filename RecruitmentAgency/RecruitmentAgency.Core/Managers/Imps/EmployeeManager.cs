using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Repositories;

namespace RecruitmentAgency.Core.Managers.Imps
{
    /// <summary>
    /// Менеджер сущности <see cref="Employee"/>
    /// </summary>
    public class EmployeeManager:ManagerBase<IEmployeeRepository, Employee, int>,IEmployeeManager
    {
        public EmployeeManager(IEmployeeRepository employeeRepository) : base(employeeRepository)
        {

        }

       /// <inheritdoc/>
        public Employee GetByUser(string login)
        {
            return repository.Get(c => c.User.Login == login);
        }
    }
}
