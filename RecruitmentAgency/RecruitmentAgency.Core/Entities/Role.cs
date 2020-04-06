using RecruitmentAgency.Domain.Entities;
using System.Collections.Generic;

namespace RecruitmentAgency.Core.Entities
{
    public class Role: Entity
    {
        public virtual string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Пользователи
        /// </summary>
        public virtual IEnumerable<User> Users
        {
            get;
            set;
        }
    }
}
