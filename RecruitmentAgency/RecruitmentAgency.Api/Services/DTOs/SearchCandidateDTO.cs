using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitmentAgency.Api.Services.DTOs
{
    public class SearchCandidateDTO
    {
        public int Experience
        {
            get;
            set;
        }

        public string ProfessionalField
        {
            get;
            set;
        }

        public string Skills
        {
            get;
            set;
        }
    }
}
