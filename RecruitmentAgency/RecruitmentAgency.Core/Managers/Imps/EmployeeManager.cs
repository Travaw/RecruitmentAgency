using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Repositories;

namespace RecruitmentAgency.Core.Managers.Imps
{
    /// <summary>
    /// Менеджер сущности <see cref="Employee"/>
    /// </summary>
    public class EmployeeManager:ManagerBase<IEmployeeRepository, Employee, int>,IEmployeeManager
    {
        private const string entityName = "Employee";

        public EmployeeManager(IEmployeeRepository employeeRepository) : base(employeeRepository)
        {

        }

       /// <inheritdoc/>
        public Employee GetByUser(string login)
        {
            var employee = repository.Get(c => c.User.Login == login);
            return employee;
        }
    }
}
