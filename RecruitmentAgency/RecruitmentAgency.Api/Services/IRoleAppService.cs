using RecruitmentAgency.Api.Services.DTOs;

namespace RecruitmentAgency.Api.Services
{
    public interface IRoleAppService: ICommonAppService<RoleDTO, RoleDTO, RoleDTO>
    {
        RoleDTO Get(string roleName);
    }
}
