using System.ComponentModel.DataAnnotations;

namespace RecruitmentAgency.Web.Models
{
    /// <summary>
    /// Модель для работоателя
    /// </summary>
    public class EmployeeModel
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Название компании
        /// </summary>
        [Display(Name = "Компания")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Аккаунт работодателя
        /// </summary>
        public UserModel User
        {
            get;
            set;
        }
    }
}