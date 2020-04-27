using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.Core.Managers
{
    /// <summary>
    /// Менеджер сущности <see cref="User"/>
    /// </summary>
    public interface IUserManager: IManager<User, int>
    {
        /// <summary>
        /// Получение учётной записи пользователя по логину
        /// </summary>
        /// <param name="login">Логин</param>
        /// <returns></returns>
        User Get(string login);

        /// <summary>
        ///  Получение учётной записи пользователя по логину и паролю
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns></returns>
        User Get(string login, string password);
    }
}
