using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecruitmentAgency.Web.Models
{
    public class VacancyModel
    {
        
        public int Id
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

        [Display(Name = "Должность")]
        public string Name
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

        [Display(Name = "Создана")]
        public DateTime CreationDate
        {
            get;
            set;
        }

        [Display(Name = "Действует до")]
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

        
        public bool IsActive
        {
            get;
            set;
        }

        public EmployeeModel Employee
        {
            get;
            set;
        }
    }
}