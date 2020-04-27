using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.NHibernate.Mappings
{
    /// <summary>
    /// Описание структуры сущности <see cref="Employee"/>
    /// </summary>
    public class EmployeeMap: ClassMapping<Employee>
    {
        /// <summary>
        ///Инициализация экземпляра <see cref="CandidateMap"/>
        /// </summary>
        public EmployeeMap()
        {
            Id(property => property.Id, mapper =>
            {
                mapper.Generator(Generators.Native);
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
                mapping.Column(FKColumnNames.UserFK);
                mapping.Cascade(Cascade.All);
            });

            Table(Employee.TableName);
        }
    }
}
