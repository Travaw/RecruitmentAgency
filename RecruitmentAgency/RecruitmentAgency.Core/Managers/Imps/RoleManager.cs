using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Repositories;

namespace RecruitmentAgency.Core.Managers.Imps
{
    public class RoleManager : ManagerBase<IRoleRepository, Role, int>, IRoleManager
    {
        public RoleManager(IRoleRepository roleRepository) : base(roleRepository)
        {

        }
        public Role Get(string roleName)
        {
            return repository.Get(u => u.Name == roleName);
        }
    }
}
