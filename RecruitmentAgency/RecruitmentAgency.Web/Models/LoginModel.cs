using System.ComponentModel.DataAnnotations;

namespace RecruitmentAgency.Web.Models
{
    /// <summary>
    /// Модель для входа
    /// </summary>
    public class LoginModel
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
        /// Пароль
        /// </summary>
        [Required]
        [Display(Name = "Пароль")]
        public string Password
        {
            get;
            set;
        }
    }
}