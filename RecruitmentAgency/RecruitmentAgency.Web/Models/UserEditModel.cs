using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecruitmentAgency.Web.Models
{
    /// <summary>
    /// Модель для редактирования пользователя
    /// </summary>
    public class UserEditModel
    {
        /// <summary>
        /// Иднтификатор
        /// </summary>
        [Required]
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Электронная почта
        /// </summary>
        [Required]
        public string Email
        {
            get;
            set;
        }
    }
}