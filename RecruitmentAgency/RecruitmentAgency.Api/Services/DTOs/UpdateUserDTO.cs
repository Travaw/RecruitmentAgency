using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.Api.Services.DTOs
{
    /// <summary>
    /// DTO для обновления сущности <see cref="User"/>
    /// </summary>
    public class UpdateUserDTO
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
        /// Электронная почта
        /// </summary>
        public string Email
        {
            get;
            set;
        }

    }
}
