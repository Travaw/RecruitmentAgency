using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecruitmentAgency.Web.Models
{
    public class UsersModel
    {
        public ICollection<EmployeeModel> Employees
        {
            get;
            set;
        }
    }
}