using System.Collections.Generic;

namespace RecruitmentAgency.Web.Models
{
    /// <summary>
    /// Модель для списка пользователей
    /// </summary>
    public class UsersModel
    {
        public ICollection<EmployeeModel> Employees
        {
            get;
            set;
        }
    }
}