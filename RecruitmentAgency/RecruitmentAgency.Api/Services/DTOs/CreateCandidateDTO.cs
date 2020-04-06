using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitmentAgency.Api.Services.DTOs
{
    public class CreateCandidateDTO
    {
        public string Firstname
        {
            get;
            set;
        }

        public string Secondname
        {
            get;
            set;
        }

        public string Patronimic
        {
            get;
            set;
        }

        public int Experience //переделать на список мест работы
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
        public byte[] Photo
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
