﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecruitmentAgency.Web.Models
{
    public class VacancyCreateModel
    {
        [Display(Name="Должность")]
        public string Name
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

        [Display(Name = "Опыт работы")]
        public int Experience
        {
            get;
            set;
        }

        [Display(Name = "Описание")]
        public string Description
        {
            get;
            set;
        }

        [Display(Name = "Требования")]
        public string Requierements
        {
            get;
            set;
        }

        [Display(Name = "Срок действия")]
        public DateTime Period
        {
            get;
            set;
        }

        [Display(Name = "З/п от")]
        public int SalaryFrom
        {
            get;
            set;
        }

        [Display(Name = "до")]
        public int SalaryTo
        {
            get;
            set;
        }
    }
}