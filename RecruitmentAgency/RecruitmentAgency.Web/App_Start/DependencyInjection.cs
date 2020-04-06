using Ninject.Modules;
using RecruitmentAgency.Core.Repositories;
using RecruitmentAgency.NHibernate.Repositories;
using RecruitmentAgency.NHibernate;
using RecruitmentAgency.Core.Managers.Imps;
using RecruitmentAgency.Core.Managers;
using NHibernate;
using AutoMapper;
using RecruitmentAgency.Api;
using RecruitmentAgency.Api.Services;
using RecruitmentAgency.Api.Services.Imps;
using System.Web.Security;
using RecruitmentAgency.Web.Providers;
using System.Web.ModelBinding;

namespace RecruitmentAgency.Web
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            
            Bind<IUserRepository>().To<UserRepository>();
            Bind<ICandidateRepository>().To<CandidateRepository>();
            Bind<IEmployeeRepository>().To<EmployeeRepository>();
            Bind<IVacancyRepository>().To<VacancyRepository>();
            Bind<IRoleRepository>().To<RoleRepository>();

            Bind<IUserManager>().To<UserManager>();
            Bind<IRoleManager>().To<RoleManager>();
            Bind<ICandidateManager>().To<CandidateManager>();
            Bind<IEmployeeManager>().To<EmployeeManager>();
            Bind<IVacancyManager>().To<VacancyManager>();

            Bind<IUserAppService>().To<UserAppService>();
            Bind<ICandidateAppService>().To<CandidateAppService>();
            Bind<IEmployeeAppService>().To<EmployeeAppService>();
            Bind<IVacancyAppService>().To<VacancyAppService>();
            Bind<IRoleAppService>().To<RolleAppService>();

            var sessionFactory = NHibernateHelper.Config();
            Bind<ISessionFactory>().ToConstant(sessionFactory).InSingletonScope();//ToMethod(c => NHibernateHelper.Config()).InSingletonScope();
            Bind<ISession>().ToMethod(c => sessionFactory.OpenSession()).InThreadScope();
            //Bind<IValueResolver<SourceEntity, DestModel, bool>>().To<MyResolver>();
            var mapperConfiguration = CreateConfiguration();
            Bind<MapperConfiguration>().ToConstant(mapperConfiguration).InSingletonScope();

            // This teaches Ninject how to create automapper instances say if for instance
            // MyResolver has a constructor with a parameter that needs to be injected
            Bind<IMapper>().ToMethod(ctx => new Mapper(mapperConfiguration));

            Unbind<ModelValidatorProvider>();
        }

        private MapperConfiguration CreateConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Add all profiles in current assembly
                cfg.AddMaps(typeof(AgencyApplicationModule).Assembly, typeof(MvcApplication).Assembly);
            });

            return config;
        }

        
    }

}