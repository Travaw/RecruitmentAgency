using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace RecruitmentAgency.Web.Models
{
    /// <summary>
    /// Модель для создания пользователя
    /// </summary>
    public class UserCreateModel
    {   
        /// <summary>
        /// Логин
        /// </summary>
        [Required]
        [Display(Name = "Логин")]
        public string Login
        {
            get;
            set;
        }

        /// <summary>
        /// Электронная почта
        /// </summary>
        [Required]
        [Display(Name = "Электронная почта")]
        public string Email
        {
            get;
            set;
        }

        /// <summary>
        /// Пароль
        /// </summary>
        [Required]
        [Display(Name = "Пароль")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>
        /// Идентификатор роли
        /// </summary>
        [Required]
        [Display(Name = "Роль")]
        public string RoleId
        {
            get;
            set;
        }

        /// <summary>
        /// Список ролей пользователя
        /// </summary>
        public SelectList Roles
        {
            get;
            set;
        }
    }
}