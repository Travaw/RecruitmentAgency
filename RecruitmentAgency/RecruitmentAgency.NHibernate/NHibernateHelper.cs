using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Mapping.ByCode;

namespace RecruitmentAgency.NHibernate
{
    /// <summary>
    /// Хелпер
    /// </summary>
    public class NHibernateHelper
    {
        /// <summary>
        /// Настройка и создание экземпляра <see cref="ISessionFactory"/> 
        /// </summary>
        /// <param name="connectionString">Строка подключения</param>
        /// <returns></returns>
        public static ISessionFactory Config(string connectionString)
        {
            var mapper = new ModelMapper();
            mapper.AddMappings(typeof(AgencyNHibernateModule).Assembly.ExportedTypes);
            var mappings = mapper.CompileMappingForAllExplicitlyAddedEntities();
            var configuration = new Configuration();            
            configuration.DataBaseIntegration(c =>
            {
                c.Dialect<MsSql2012Dialect>();
                c.ConnectionString = connectionString;
            });
            configuration.AddMapping(mappings);
            var sessionFactory = configuration.BuildSessionFactory();
            return sessionFactory;
        }
    }
}
