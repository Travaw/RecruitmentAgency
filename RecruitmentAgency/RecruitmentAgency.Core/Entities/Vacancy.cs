using System;

using RecruitmentAgency.Domain.Entities;

namespace RecruitmentAgency.Core.Entities
{
    public class Vacancy: Entity
    {
        public virtual string Name
        {
            get;
            set;
        }

        public virtual string Description
        {
            get;
            set;
        }

        public virtual int Experience
        {
            get;
            set;
        }

        public virtual string Requierements
        {
            get;
            set;
        }

        public virtual string ProfessionalField
        {
            get;
            set;
        }

        public virtual Employee Employee
        {
            get;
            set;
        }

        public virtual DateTime CreationDate
        {
            get;
            set;
        }

        public virtual DateTime Period
        {
            get;
            set;
        }

        public virtual int SalaryFrom
        {
            get;
            set;
        }

        public virtual int SalaryTo
        {
            get;
            set;
        }
        public virtual bool IsActive
        {
            get;
            set;
        }

    }
}
