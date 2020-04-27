using System.ComponentModel.DataAnnotations;

namespace RecruitmentAgency.Web.Models
{
    /// <summary>
    /// Модель для поиска вакансий
    /// </summary>
    public class VacancySearchModel
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
        /// Описание
        /// </summary>
        [Display(Name = "Описание")]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Опыт работы
        /// </summary>
        [Display(Name = "Опыт работы")]
        [Range(0,80)]
        public int? Experience
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
        /// Сфера деятельности
        /// </summary>
        [Display(Name = "Сфера деятельности")]
        public string ProfessionalField
        {
            get;
            set;
        }

        /// <summary>
        /// з/п
        /// </summary>
        [Display(Name = "Зарплата")]
        public int? Salary
        {
            get;
            set;
        }        
    }
}