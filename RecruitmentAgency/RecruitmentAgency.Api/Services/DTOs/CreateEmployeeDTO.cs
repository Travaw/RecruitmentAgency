using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.Api.Services.DTOs
{
    /// <summary>
    /// DTO для создания сущности <see cref="Employee"/>
    /// </summary>
    public class CreateEmployeeDTO
    {
        /// <summary>
        /// Название компании
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string UserName
        {
            get;
            set;
        }
    }
}
