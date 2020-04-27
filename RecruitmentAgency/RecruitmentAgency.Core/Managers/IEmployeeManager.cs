using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.Core.Managers
{
    /// <summary>
    /// Менеджер сущности <see cref="Employee"/>
    /// </summary>
    public interface IEmployeeManager : IManager<Employee, int>
    {
        /// <summary>
        /// Получение работодателя по логину
        /// </summary>
        /// <param name="login">Логин</param>
        /// <returns></returns>
        Employee GetByUser(string login);
    }
}
