using RecruitmentAgency.Api.Services.DTOs;

namespace RecruitmentAgency.Api.Services
{
    /// <summary>
    /// Сервис для работы с учётными записями пользователей
    /// </summary>
    public interface IUserAppService: ICommonAppService<UserDTO, CreateUserDTO, UpdateUserDTO>
    {
        /// <summary>
        /// Получение пользователя по логину
        /// </summary>
        /// <param name="login">Логин</param>
        /// <returns></returns>
        UserDTO Get(string login);

        /// <summary>
        /// Получение пользователя по логину и паролю
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns></returns>
        UserDTO Get(string login, string password);
    }
}
