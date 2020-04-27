using RecruitmentAgency.Domain.Entities;

namespace RecruitmentAgency.Core.Entities
{
    /// <summary>
    /// Работодатель
    /// </summary>
    public class Employee:Entity
    {
        /// <summary>
        /// Имя таблицы
        /// </summary>
        public const string TableName = "Employees";

        /// <summary>
        /// Назвние компании
        /// </summary>
        public virtual string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Учётная запись
        /// </summary>
        public virtual User User
        {
            get;
            set;
        }
    }
}
