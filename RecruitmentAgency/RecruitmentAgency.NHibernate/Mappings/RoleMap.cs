﻿using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.NHibernate.Mappings
{
    /// <summary>
    /// Описание структуры сущности <see cref="Role"/>
    /// </summary>
    public class RoleMap : ClassMapping<Role>
    {
        /// <summary>
        /// Инициализировать экземпляр <see cref="RoleMap"/>
        /// </summary>
        public RoleMap()
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

            Set(property => property.Users,
                collectionMapping =>
                {
                    collectionMapping.Key(keyMapping =>
                    {
                        keyMapping.Column(FKColumnNames.RoleFK);
                    });
                    collectionMapping.Cascade(Cascade.All);
                },
                mapping =>
                {
                    mapping.OneToMany();
                }
            );

            Table(Role.TableName);
        }
    }
}
