using System;

using RecruitmentAgency.Domain.Entities;

namespace RecruitmentAgency.Core.Entities
{
    

    /// <summary>
    /// Вакансия
    /// </summary>
    public class Vacancy: Entity
    {
        /// <summary>
        /// Имя таблицы
        /// </summary>
        public const string TableName = "Vacancies";

        /// <summary>
        /// Название
        /// </summary>
        public virtual string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Описание
        /// </summary>
        public virtual string Description
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
        /// Требования
        /// </summary>
        public virtual string Requierements
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
        /// Работодатель
        /// </summary>
        public virtual Employee Employee
        {
            get;
            set;
        }

        /// <summary>
        /// Дата создания
        /// </summary>
        public virtual DateTime CreationDate
        {
            get;
            set;
        }

        /// <summary>
        /// Срок действия
        /// </summary>
        public virtual DateTime Period
        {
            get;
            set;
        }

        /// <summary>
        /// Минимальная з/п
        /// </summary>
        public virtual int SalaryFrom
        {
            get;
            set;
        }

        /// <summary>
        /// Максимальная з/п
        /// </summary>
        public virtual int SalaryTo
        {
            get;
            set;
        }

        /// <summary>
        /// Открыта
        /// </summary>
        public virtual bool IsActive
        {
            get;
            set;
        }

    }
}
