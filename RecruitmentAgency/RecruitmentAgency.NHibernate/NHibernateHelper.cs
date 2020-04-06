using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Mapping.ByCode;
using NHibernate.Tool.hbm2ddl;
using config=System.Configuration;

namespace RecruitmentAgency.NHibernate
{
    public class NHibernateHelper
    {
        public static ISessionFactory Config()
        {
            var mapper = new ModelMapper();
            mapper.AddMappings(typeof(AgencyNHibernateModule).Assembly.ExportedTypes);
            var mappings = mapper.CompileMappingForAllExplicitlyAddedEntities();
            var configuration = new Configuration();
            // var mappings = mapper.CompileMappingForAllExplicitlyAddedEntities();
           //string cs = config.ConfigurationManager.ConnectionStrings["RecruitmentAgencyDb"].ConnectionString;
            configuration.DataBaseIntegration(c =>
            {
                c.Dialect<MsSql2012Dialect>();
                c.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RecruitmentAgencyDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                //c.KeywordsAutoImport = Hbm2DDLKeyWords.AutoQuote;
                //c.SchemaAction = SchemaAutoAction.Validate;
                //c.LogFormattedSql = true;
                //c.LogSqlInConsole = true;
            });
            //new SchemaExport(configuration).Execute(true, true, false);
            configuration.AddMapping(mappings);
            var sessionFactory = configuration.BuildSessionFactory();
            return sessionFactory;
        }
    }
}
