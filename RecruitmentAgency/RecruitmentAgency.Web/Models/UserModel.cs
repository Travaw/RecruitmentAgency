﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecruitmentAgency.Web.Models
{
    public class UserModel
    {
        public int Id
        {
            get;
            set;
        }

        public string Login
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }
    }
}