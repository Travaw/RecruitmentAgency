using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecruitmentAgency.Web.Models
{
    public class EmployeeCreateModel
    {
        [Required]
        [Display(Name="Компания")]
        public string Name
        {
            get;
            set;
        }

    }
}