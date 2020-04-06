using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.NHibernate.Mappings
{
    /// <summary>
    /// Описание структуры сущности <see cref="User"/>
    /// </summary>
    public class UserMap : ClassMapping<User>
    {
        /// <summary>
        /// Инициализировать экземпляр <see cref="UserMap"/>
        /// </summary>
        public UserMap()
        {
            Id(x => x.Id, x =>
            {
                x.Generator(Generators.Increment);
                x.Type(NHibernateUtil.Int32);
                x.Column("Id");
            });

            Property(b => b.Login, x =>
            {
                x.Type(NHibernateUtil.String);
            });

            Property(b => b.Email, x =>
            {
                x.Type(NHibernateUtil.String);
            });

            Property(b => b.Password, x =>
            {
                x.Type(NHibernateUtil.String);
            });



            ManyToOne(property => property.Role, mapping =>
            {
                mapping.Column("RoleId");
                mapping.Cascade(Cascade.All);
            });

            OneToOne(property => property.Candidate, mapping =>
            {
                mapping.Class(typeof(Candidate));
            });

            OneToOne(property => property.Employee, mapping =>
            {
                mapping.Class(typeof(Employee));
            });

            Table("Users");
        }
    }
}
