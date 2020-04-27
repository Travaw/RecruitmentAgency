using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.NHibernate.Mappings
{
    /// <summary>
    /// Описание структуры сущности <see cref="Candidate"/>
    /// </summary>
    public class CandidateMap : ClassMapping<Candidate>
    {
        /// <summary>
        /// Инициализация экземпляра <see cref="CandidateMap"/>
        /// </summary>
        public CandidateMap()
        {
            Id(property=>property.Id, mapper =>
             {
                 mapper.Generator(Generators.Native);
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
                mapping.Column(FKColumnNames.UserFK);
                mapping.Cascade(Cascade.All);
            });

            Table(Candidate.TableName);
        }
    }
}
