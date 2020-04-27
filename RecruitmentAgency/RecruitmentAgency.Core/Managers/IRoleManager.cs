using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.Core.Managers
{
    /// <summary>
    /// Менеджер сущности <see cref="Role"/>
    /// </summary>
    public interface IRoleManager : IManager<Role, int>
    {
        /// <summary>
        /// Получение роли
        /// </summary>
        /// <param name="roleName">Имя роли</param>
        /// <returns></returns>
        Role Get(string roleName);
    }
}
