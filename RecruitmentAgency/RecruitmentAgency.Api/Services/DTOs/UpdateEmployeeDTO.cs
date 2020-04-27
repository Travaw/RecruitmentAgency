using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.Api.Services.DTOs
{
    /// <summary>
    /// DTO для обновления сущности <see cref="Employee"/>
    /// </summary>
    public class UpdateEmployeeDTO
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
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Идентификатор аккаунта
        /// </summary>
        public int? UserId
        {
            get;
            set;
        }
    }
}
