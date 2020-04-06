using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitmentAgency.Api.Services.DTOs
{
    public class CreateVacancyDTO
    {
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

        public string ProfessionalField
        {
            get;
            set;
        }

        public DateTime Period
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

        public string UserName
        {
            get;
            set;
        }
    }
}
