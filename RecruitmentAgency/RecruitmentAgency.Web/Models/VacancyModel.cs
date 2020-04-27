using System;
using System.ComponentModel.DataAnnotations;

namespace RecruitmentAgency.Web.Models
{
    /// <summary>
    /// Модель для вакансии
    /// </summary>
    public class VacancyModel
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id
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
        /// Должность
        /// </summary>
        [Display(Name = "Должность")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Опыт работы
        /// </summary>
        [Display(Name = "Опыт работы")]
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
        /// Дата создания
        /// </summary>
        [Display(Name = "Создана")]
        public DateTime CreationDate
        {
            get;
            set;
        }

        /// <summary>
        /// Срок действия
        /// </summary>
        [Display(Name = "Действует до")]
        public DateTime Period
        {
            get;
            set;
        }

        /// <summary>
        /// Минимальная з/п
        /// </summary>
        [Display(Name = "З/п от")]
        public int SalaryFrom
        {
            get;
            set;
        }

        /// <summary>
        /// Масмальная з/п
        /// </summary>
        [Display(Name = "до")]
        public int SalaryTo
        {
            get;
            set;
        }

        /// <summary>
        /// Статус (открыта/закрыта)
        /// </summary>
        public bool IsActive
        {
            get;
            set;
        }

        /// <summary>
        /// Работодатель
        /// </summary>
        public EmployeeModel Employee
        {
            get;
            set;
        }
    }
}