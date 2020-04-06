using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.Core.Managers
{
    public interface IRoleManager : IManager<Role, int>
    {
        Role Get(string roleName);
    }
}
