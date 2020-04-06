using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using RecruitmentAgency.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitmentAgency.NHibernate.Mappings
{
    public class EmployeeMap: ClassMapping<Employee>
    {
        public EmployeeMap()
        {
            Id(property => property.Id, mapper =>
            {
                mapper.Generator(Generators.Increment);
                mapper.Type(NHibernateUtil.Int32);
                mapper.Column("Id");
            });

            Property(property => property.Name, mapping =>
            {
                mapping.Type(NHibernateUtil.String);
                mapping.NotNullable(true);
            });            

            ManyToOne(property => property.User, mapping =>
            {
                mapping.Column("UserId");
                mapping.Cascade(Cascade.All);
            });

            Table("Employees");
        }
    }
}
