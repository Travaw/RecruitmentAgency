using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Repositories;

namespace RecruitmentAgency.Core.Managers.Imps
{
    /// <summary>
    /// Менеджер сущности <see cref="Role"/>
    /// </summary>
    public class RoleManager : ManagerBase<IRoleRepository, Role, int>, IRoleManager
    {
        public RoleManager(IRoleRepository roleRepository) : base(roleRepository)
        {

        }

        /// <summary>
        /// Получение роли
        /// </summary>
        /// <param name="roleName">Имя роли</param>
        /// <returns></returns>
        public Role Get(string roleName)
        {
            return repository.Get(u => u.Name == roleName);
        }
    }
}
