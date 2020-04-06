using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecruitmentAgency.Web.Models
{
    public class CandidateCreateModel
    {
        [Display(Name = "Имя")][Required]
        public string Firstname
        {
            get;
            set;
        }

        [Display(Name = "Фамилия")]
        [Required]
        public string Secondname
        {
            get;
            set;
        }

        [Display(Name = "Отчество")]
        [Required]
        public string Patronimic
        {
            get;
            set;
        }

        [Display(Name = "Сфера деятельности")]
        [Required]
        public string ProfessionalField
        {
            get;
            set;
        }

        [Display(Name = "Навыки")]
        [Required]
        public string Skills
        {
            get;
            set;
        }

        [Display(Name = "Опыт работы (лет)")]
        [Required]
        public int Experience //переделать на список мест работы
        {
            get;
            set;
        }

        [Required]
        public HttpPostedFileBase Photo
        {
            get;
            set;
        }
        
    }
}