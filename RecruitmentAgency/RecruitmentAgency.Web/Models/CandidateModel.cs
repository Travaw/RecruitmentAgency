using RecruitmentAgency.Api.Services.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecruitmentAgency.Web.Models
{
    public class CandidateModel
    {
        
        public int Id
        {
            get;
            set;
        }

        [Display(Name = "Имя")]
        public string Firstname
        {
            get;
            set;
        }

        [Display(Name = "Фамилия")]
        public string Secondname
        {
            get;
            set;
        }

        [Display(Name = "Отчество")]
        public string Patronimic
        {
            get;
            set;
        }

        [Display(Name ="Опыт работы (лет)")]
        public int Experience //переделать на список мест работы
        {
            get;
            set;
        }

        [Display(Name = "Сфера деятельности")]
        public string ProfessionalField
        {
            get;
            set;
        }

        [Display(Name = "Навыки")]
        public string Skills
        {
            get;
            set;
        }
        public string Photo
        {
            get;
            set;
        }

        public UserDTO User
        {
            get;
            set;
        }
    }
}