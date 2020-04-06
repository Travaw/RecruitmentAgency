using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.NHibernate.Mappings
{
    public class CandidateMap : ClassMapping<Candidate>
    {
        public CandidateMap()
        {
            Id(property=>property.Id, mapper =>
             {
                 mapper.Generator(Generators.Increment);
                 mapper.Type(NHibernateUtil.Int32);
                 mapper.Column("Id");
             });

            Property(property => property.Firstname, mapping =>
            {
                mapping.Type(NHibernateUtil.String);
                mapping.NotNullable(true);
            });

            Property(property => property.Secondname, mapping =>
            {
                mapping.Type(NHibernateUtil.String);
                mapping.NotNullable(true);
            });

            Property(property => property.Patronimic, mapping =>
            {
                mapping.Type(NHibernateUtil.String);
                mapping.NotNullable(true);
            });

            Property(property => property.Photo, mapping =>
            {
                mapping.Type(NHibernateUtil.String);
                mapping.NotNullable(true);
            });

            Property(property => property.Experience, mapping =>
            {
                mapping.Type(NHibernateUtil.Int32);
                mapping.NotNullable(true);
            });

            Property(property => property.ProfessionalField, mapping =>
            {
                mapping.Type(NHibernateUtil.String);
                mapping.NotNullable(true);
            });

            Property(property => property.Skills, mapping =>
            {
                mapping.Type(NHibernateUtil.String);
                mapping.NotNullable(true);
            });

            ManyToOne(property => property.User, mapping =>
            {
                mapping.Column("UserId");
                mapping.Cascade(Cascade.All);
            });
            /*
            OneToOne(property => property.User, mapping =>
            {
                mapping.Class(typeof(User));
                mapping.Cascade(Cascade.Persist);
                mapping.Constrained(true);
                mapping.Lazy(LazyRelation.Proxy); // or .NoProxy, .NoLazy
               // mapping.PropertyReference(typeof(User).GetPropertyOrFieldMatchingName("OtherSideProperty"));
               // mapping.OptimisticLock(true);
               // mapping.Formula("arbitrary SQL expression");
               // mapping.Access(Accessor.Field);
                mapping.ForeignKey("FK_Candidates_ToUsers");
              //Column("ExecutorId");
            });*/

            Table("Candidates");
        }
    }
}
