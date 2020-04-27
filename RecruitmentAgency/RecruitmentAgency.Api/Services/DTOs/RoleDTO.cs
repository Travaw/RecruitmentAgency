using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.Api.Services.DTOs
{
    /// <summary>
    /// DTO для сущности <see cref="Role"/>
    /// </summary>
    public class RoleDTO
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
        /// Название роли
        /// </summary>
        public string Name
        {
            get;
            set;
        }        
    }
}
