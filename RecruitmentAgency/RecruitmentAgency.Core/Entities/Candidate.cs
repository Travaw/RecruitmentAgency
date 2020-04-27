using RecruitmentAgency.Domain.Entities;

namespace RecruitmentAgency.Core.Entities
{
    /// <summary>
    /// Кандидат
    /// </summary>
    public class Candidate:Entity
    {
        /// <summary>
        /// Имя таблицы
        /// </summary>
        public const string TableName = "Candidates";

        /// <summary>
        /// Имя
        /// </summary>
        public virtual string Firstname
        {
            get;
            set;
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        public virtual string Secondname
        {
            get;
            set;
        }

        /// <summary>
        /// Отчество
        /// </summary>
        public virtual string Patronimic
        {
            get;
            set;
        }

        /// <summary>
        /// Опыт работы
        /// </summary>
        public virtual int Experience 
        {
            get;
            set;
        }

        /// <summary>
        /// Сфера деятельности
        /// </summary>
        public virtual string ProfessionalField
        {
            get;
            set;
        }

        /// <summary>
        /// Навыки
        /// </summary>
        public virtual string Skills
        {
            get;
            set;
        }

        /// <summary>
        /// Фотография
        /// </summary>
        public virtual string Photo
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
