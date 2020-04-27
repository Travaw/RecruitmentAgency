using System.ComponentModel.DataAnnotations;

using RecruitmentAgency.Api.Services.DTOs;

namespace RecruitmentAgency.Web.Models
{
    /// <summary>
    /// Модель для созания резюме
    /// </summary>
    public class CandidateModel
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
        /// Имя
        /// </summary>
        [Display(Name = "Имя")]
        public string Firstname
        {
            get;
            set;
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        [Display(Name = "Фамилия")]
        public string Secondname
        {
            get;
            set;
        }

        /// <summary>
        /// Отчество
        /// </summary>
        [Display(Name = "Отчество")]
        public string Patronimic
        {
            get;
            set;
        }

        /// <summary>
        /// Опыт работы
        /// </summary>
        [Display(Name ="Опыт работы (лет)")]
        public int Experience //переделать на список мест работы
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

        /// <summary>
        /// Фотография
        /// </summary>
        public string Photo
        {
            get;
            set;
        }

        /// <summary>
        /// Пользователь
        /// </summary>
        public UserDTO User
        {
            get;
            set;
        }
    }
}