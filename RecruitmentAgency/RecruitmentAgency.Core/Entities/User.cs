using RecruitmentAgency.Domain.Entities;

namespace RecruitmentAgency.Core.Entities
{
    public class User: Entity
    {
        public virtual string Login
        {
            get;
            set;
        }

        public virtual string Email
        {
            get;
            set;
        }

        public virtual string Password
        {
            get;
            set;
        }

        public virtual Role Role
        {
            get;
            set;
        }

        public virtual Candidate Candidate
        {
            get;
            set;
        }

        public virtual Employee Employee
        {
            get;
            set;
        }
    }
}
