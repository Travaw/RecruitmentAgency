using System.ComponentModel.DataAnnotations;
using System.Web;

namespace RecruitmentAgency.Web.Models
{
    /// <summary>
    /// Модель для созания резюме
    /// </summary>
    public class CandidateCreateModel
    {
        /// <summary>
        /// Имя
        /// </summary>
        [Display(Name = "Имя")]
        [Required]
        public string Firstname
        {
            get;
            set;
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        [Display(Name = "Фамилия")]
        [Required]
        public string Secondname
        {
            get;
            set;
        }

        /// <summary>
        /// Отчество
        /// </summary>
        [Display(Name = "Отчество")]
        [Required]
        public string Patronimic
        {
            get;
            set;
        }

        /// <summary>
        /// Сфера деятельности
        /// </summary>
        [Display(Name = "Сфера деятельности")]
        [Required]
        public string ProfessionalField
        {
            get;
            set;
        }

        /// <summary>
        /// Навыки
        /// </summary>
        [Display(Name = "Навыки")]
        [Required]
        public string Skills
        {
            get;
            set;
        }

        /// <summary>
        /// Опыт работы
        /// </summary>
        [Display(Name = "Опыт работы (лет)")]
        [Required]
        [Range(0, 80)]
        public int Experience 
        {
            get;
            set;
        }

        /// <summary>
        /// Фотография
        /// </summary>
        [Required]
        public HttpPostedFileBase Photo
        {
            get;
            set;
        }
        
    }
}