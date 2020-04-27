using System.ComponentModel.DataAnnotations;
using System.Web;

namespace RecruitmentAgency.Web.Models
{
    /// <summary>
    /// одель для изменния резюме
    /// </summary>
    public class CandidateEditModel
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Required]
        public int Id
        {
            get;
            set;
        }

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
        /// Старая фотография
        /// </summary>
        [Required]
        public string OldPhoto
        {
            get;
            set;
        }

        /// <summary>
        /// Новая фотография
        /// </summary>
        public HttpPostedFileBase NewPhoto
        {
            get;
            set;
        }
    }
}