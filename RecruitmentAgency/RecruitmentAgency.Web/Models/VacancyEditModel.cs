using System;

namespace RecruitmentAgency.Web.Models
{
    /// <summary>
    /// Модель для реактирования вакансии
    /// </summary>
    public class VacancyEditModel
    {
        /// <summary>
        /// Иентификатор
        /// </summary>
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Должность
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Опыт работы
        /// </summary>
        public int Experience
        {
            get;
            set;
        }

        /// <summary>
        /// Требования
        /// </summary>
        public string Requierements
        {
            get;
            set;
        }

        /// <summary>
        /// Срок действия
        /// </summary>
        public DateTime Period
        {
            get;
            set;
        }

        /// <summary>
        /// з/п
        /// </summary>
        public int Salary
        {
            get;
            set;
        }

        /// <summary>
        /// Минимльная з/п
        /// </summary>
        public int SalaryFrom
        {
            get;
            set;
        }

        /// <summary>
        /// Максимльная зарплата
        /// </summary>
        public int SalaryTo
        {
            get;
            set;
        }
    }
}