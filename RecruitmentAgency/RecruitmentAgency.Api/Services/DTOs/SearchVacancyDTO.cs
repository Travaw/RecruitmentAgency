using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitmentAgency.Api.Services.DTOs
{
    public class SearchVacancyDTO
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
       
        public string Requierements
        {
            get;
            set;
        }

        public int? Experience
        {
            get;
            set;
        }
        public string ProfessionalField
        {
            get;
            set;
        }


        public int? Salary
        {
            get;
            set;
        }
    }
}
