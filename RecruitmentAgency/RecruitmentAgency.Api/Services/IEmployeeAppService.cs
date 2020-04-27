using RecruitmentAgency.Api.Services.DTOs;

namespace RecruitmentAgency.Api.Services
{
    /// <summary>
    /// Серфис для работы с работодателями
    /// </summary>
    public interface IEmployeeAppService : ICommonAppService<EmployeeDTO, CreateEmployeeDTO, UpdateEmployeeDTO>
    {
        /// <summary>
        /// Плучение работодателя по логину учётной записи
        /// </summary>
        /// <param name="login">Логин</param>
        /// <returns></returns>
        EmployeeDTO GetByUser(string login);
    }
}
