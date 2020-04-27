using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.Api.Services.DTOs
{
    /// <summary>
    /// DTO для сущности <see cref="Employee"/>
    /// </summary>
    public class EmployeeDTO
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
        /// Аккаунт
        /// </summary>
        public UserDTO User
        {
            get;
            set;
        }
    }
}
