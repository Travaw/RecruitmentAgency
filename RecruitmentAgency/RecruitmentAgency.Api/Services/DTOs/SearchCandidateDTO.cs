using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.Api.Services.DTOs
{
    /// <summary>
    /// DTO для поиска сущности <see cref="Candidate"/>
    /// </summary>
    public class SearchCandidateDTO
    {
        /// <summary>
        /// Опыт работы
        /// </summary>
        public int Experience //переделать на список мест работы
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
        /// Навыки
        /// </summary>
        public string Skills
        {
            get;
            set;
        }
    }
}
