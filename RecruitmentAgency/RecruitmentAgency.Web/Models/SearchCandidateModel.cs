using System.ComponentModel.DataAnnotations;

namespace RecruitmentAgency.Web.Models
{
    /// <summary>
    /// Модель для поиска кандидатов
    /// </summary>
    public class CandidateSearchModel
    {
        /// <summary>
        /// Опыт работы
        /// </summary>
        [Display(Name="Опыт работы")]
        public int? Experience
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
        /// Навыки
        /// </summary>
        [Display(Name = "Навыки")]
        public string Skills
        {
            get;
            set;
        }

    }
}