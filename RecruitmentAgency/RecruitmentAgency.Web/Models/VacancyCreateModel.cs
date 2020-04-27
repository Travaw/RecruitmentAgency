using System;
using System.ComponentModel.DataAnnotations;

namespace RecruitmentAgency.Web.Models
{
    /// <summary>
    /// Модель для создания
    /// </summary>
    public class VacancyCreateModel
    {
        /// <summary>
        /// Должность
        /// </summary>
        [Display(Name="Должность")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Сфера деятельности
        /// </summary>
        [Display(Name = "Сфера деятельности")]
        public string ProfessionalField
        {
            get;
            set;
        }

        /// <summary>
        /// Опыт работы
        /// </summary>
        [Display(Name = "Опыт работы")]
        [Range(0, 80)]
        public int Experience
        {
            get;
            set;
        }

        /// <summary>
        /// Описание
        /// </summary>
        [Display(Name = "Описание")]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Требования
        /// </summary>
        [Display(Name = "Требования")]
        public string Requierements
        {
            get;
            set;
        }

        /// <summary>
        /// Срок действия
        /// </summary>
        [Display(Name = "Срок действия")]
        public DateTime Period
        {
            get;
            set;
        }

        /// <summary>
        /// Минимльная з/п
        /// </summary>
        [Display(Name = "З/п от")]
        public int SalaryFrom
        {
            get;
            set;
        }

        /// <summary>
        /// Максимльная зарплата
        /// </summary>
        [Display(Name = "до")]
        public int SalaryTo
        {
            get;
            set;
        }
    }
}