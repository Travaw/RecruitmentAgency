using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.Api.Services.DTOs
{
    /// <summary>
    /// DTO для создания сущности <see cref="User"/>
    /// </summary>
    public class CreateUserDTO
    {
        /// <summary>
        /// Логин
        /// </summary>
        public string Login
        {
            get;
            set;
        }

        /// <summary>
        /// Электронная почта
        /// </summary>
        public string Email
        {
            get;
            set;
        }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password
        {
            get;
            set;
        }

        /// <summary>
        /// Идентификатор роли
        /// </summary>
        public int RoleId
        {
            get;
            set;
        }
    }
}
