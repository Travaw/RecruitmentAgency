using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.Api.Services.DTOs
{
    /// <summary>
    /// DTO для поиска сущности <see cref="Vacancy"/>
    /// </summary>
    public class SearchVacancyDTO
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Требования
        /// </summary>
        public string Requierements
        {
            get;
            set;
        }

        /// <summary>
        /// Опыт работы
        /// </summary>
        public int? Experience
        {
            get;
            set;
        }

        /// <summary>
        /// Сфера деятельности
        /// </summary>
        public string ProfessionalField
        {
            get;
            set;
        }

        /// <summary>
        /// з/п
        /// </summary>
        public int? Salary
        {
            get;
            set;
        }

        /// <summary>
        /// Статус
        /// </summary>
        public bool IsActive
        {
            get;
            set;
        }
    }
}
