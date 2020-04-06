using RecruitmentAgency.Domain.Entities;

namespace RecruitmentAgency.Core.Entities
{
    public class Candidate:Entity
    {
        public virtual string Firstname
        {
            get;
            set;
        }

        public virtual string Secondname
        {
            get;
            set;
        }

        public virtual string Patronimic
        {
            get;
            set;
        }

        public virtual int Experience 
        {
            get;
            set;
        }

        
        public virtual string ProfessionalField
        {
            get;
            set;
        }

        
        public virtual string Skills
        {
            get;
            set;
        }

        public virtual string Photo
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
