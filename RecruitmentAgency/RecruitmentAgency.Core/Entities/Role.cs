using System.Collections.Generic;

using RecruitmentAgency.Domain.Entities;

namespace RecruitmentAgency.Core.Entities
{
    /// <summary>
    /// Роль пользователя
    /// </summary>
    public class Role: Entity
    {
        /// <summary>
        /// Имя таблицы
        /// </summary>
        public const string TableName = "Roles";

        /// <summary>
        /// Назание роли
        /// </summary>
        public virtual string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Принадлежащие к роли пользователи
        /// </summary>
        public virtual IEnumerable<User> Users
        {
            get;
            set;
        }
    }
}
