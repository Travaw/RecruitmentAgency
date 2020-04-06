using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecruitmentAgency.Web.Models
{
    public class CandidateSearchModel
    {
        [Display(Name="Опыт работы")]
        public int? Experience
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

    }
}