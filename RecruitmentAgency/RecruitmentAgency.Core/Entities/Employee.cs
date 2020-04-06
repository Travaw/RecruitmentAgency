using RecruitmentAgency.Domain.Entities;

namespace RecruitmentAgency.Core.Entities
{
    public class Employee:Entity
    {
        public virtual string Name
        {
            get;
            set;
        }

        public virtual User User
        {
            get;
            set;
        }
    }
}
