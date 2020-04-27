using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.NHibernate.Mappings
{
    /// <summary>
    /// Описание структуры сущности <see cref="Vacancy"/>
    /// </summary>
    public class VacancyMap:ClassMapping<Vacancy>
    {
        /// <summary>
        /// Инициализировать экземпляр <see cref="VacancyMap"/>
        /// </summary>
        public VacancyMap()
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

            Property(property => property.Experience, mapping =>
            {
                mapping.Type(NHibernateUtil.Int32);
                mapping.NotNullable(true);
            });

            Property(property => property.Description, mapping =>
            {
                mapping.Type(NHibernateUtil.String);
                mapping.NotNullable(true);
            });

            Property(property => property.ProfessionalField, mapping =>
            {
                mapping.Type(NHibernateUtil.String);
                mapping.NotNullable(true);
            });

            Property(property => property.Requierements, mapping =>
            {
                mapping.Type(NHibernateUtil.String);
                mapping.NotNullable(true);
            });

            Property(property => property.CreationDate, mapping =>
            {
                mapping.Type(NHibernateUtil.DateTime);
                mapping.NotNullable(true);
            });

            Property(property => property.Period, mapping =>
            {
                mapping.Type(NHibernateUtil.DateTime);
                mapping.NotNullable(true);
            });

            Property(property => property.SalaryFrom, mapping =>
            {
                mapping.Type(NHibernateUtil.Int32);
                mapping.NotNullable(true);
            });

            Property(property => property.SalaryTo, mapping =>
            {
                mapping.Type(NHibernateUtil.Int32);
                mapping.NotNullable(true);
            });

            Property(property => property.IsActive, mapping =>
            {
                mapping.Type(NHibernateUtil.Boolean);
                mapping.NotNullable(true);
            });

            ManyToOne(property => property.Employee, mapping =>
            {
                mapping.Column(FKColumnNames.EmployeeFK);
                mapping.Cascade(Cascade.All);
            });

            Table(Vacancy.TableName);
        }
    }
}
