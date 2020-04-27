using RecruitmentAgency.Domain.Entities;

namespace RecruitmentAgency.Core.Entities
{
    /// <summary>
    /// Учётная зпись пользователя
    /// </summary>
    public class User: Entity
    {
        /// <summary>
        /// Имя таблицы
        /// </summary>
        public const string TableName = "Users";

        /// <summary>
        /// Логин
        /// </summary>
        public virtual string Login
        {
            get;
            set;
        }

        /// <summary>
        /// Электронная почта
        /// </summary>
        public virtual string Email
        {
            get;
            set;
        }

        /// <summary>
        /// Пароль
        /// </summary>
        public virtual string Password
        {
            get;
            set;
        }

        /// <summary>
        /// Роль
        /// </summary>
        public virtual Role Role
        {
            get;
            set;
        }

        /// <summary>
        /// Кандидат
        /// </summary>
        public virtual Candidate Candidate
        {
            get;
            set;
        }

        /// <summary>
        /// Работодатель
        /// </summary>
        public virtual Employee Employee
        {
            get;
            set;
        }
    }
}
