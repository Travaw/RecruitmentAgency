using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitmentAgency.Api.Services.DTOs
{
    public class UpdateVacancyDTO
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

        public string Requierements
        {
            get;
            set;
        }

        public int Experience
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

        public bool IsActive
        {
            get;
            set;
        }

        public int? EmployeeId
        {
            get;
            set;
        }
    }
}
