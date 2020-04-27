using RecruitmentAgency.Api.Services.DTOs;

namespace RecruitmentAgency.Api.Services
{
    /// <summary>
    /// Сервис для работы с ролями пользователей
    /// </summary>
    public interface IRoleAppService: ICommonAppService<RoleDTO, RoleDTO, RoleDTO>
    {
        /// <summary>
        /// Получение роли
        /// </summary>
        /// <param name="roleName">Имя роли</param>
        /// <returns></returns>
        RoleDTO Get(string roleName);
    }
}
