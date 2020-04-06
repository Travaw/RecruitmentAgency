using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitmentAgency.Api.Services.DTOs
{
    public class UpdateEmployeeDTO
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

        public int? UserId
        {
            get;
            set;
        }
    }
}
