using System.ComponentModel.DataAnnotations;

namespace RecruitmentAgency.Web.Models
{
    /// <summary>
    /// Модель для создания работодателя
    /// </summary>
    public class EmployeeCreateModel
    {
        /// <summary>
        /// Название компании
        /// </summary>
        [Required]
        [Display(Name="Компания")]
        public string Name
        {
            get;
            set;
        }

    }
}