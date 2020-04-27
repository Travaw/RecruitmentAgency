using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.Api.Services.DTOs
{
    /// <summary>
    /// DTO для обновления сущности <see cref="Candidate"/>
    /// </summary>
    public class UpdateCandidateDTO
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
        /// Имя
        /// </summary>
        public string Firstname
        {
            get;
            set;
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Secondname
        {
            get;
            set;
        }

        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronimic
        {
            get;
            set;
        }

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

        /// <summary>
        /// Фотография
        /// </summary>
        public string Photo
        {
            get;
            set;
        }


    }
}
