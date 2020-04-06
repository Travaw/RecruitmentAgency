using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecruitmentAgency.Web.Models
{
    public class VacancyEditModel
    {
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }
        public int Experience
        {
            get;
            set;
        }

        public string Requierements
        {
            get;
            set;
        }


        public DateTime Period
        {
            get;
            set;
        }

        public int Salary
        {
            get;
            set;
        }

        public int SalaryFrom
        {
            get;
            set;
        }

        public int SalaryTo
        {
            get;
            set;
        }
    }
}