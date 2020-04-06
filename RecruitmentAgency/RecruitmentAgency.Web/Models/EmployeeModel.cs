using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecruitmentAgency.Web.Models
{
    public class EmployeeModel
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

        public UserModel User
        {
            get;
            set;
        }
    }
}