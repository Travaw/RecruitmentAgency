using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecruitmentAgency.Web.Models
{
    public class UserCreateModel
    {
        [Required]
        public string Login
        {
            get;
            set;
        }

        [Required]
        public string Email
        {
            get;
            set;
        }

        [Required]
        public string Password
        {
            get;
            set;
        }

        [Required]
        public string RoleId
        {
            get;
            set;
        }
    }
}