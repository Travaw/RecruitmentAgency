using NHibernate;
using RecruitmentAgency.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitmentAgency.NHibernate.Repositories
{
    public class UnitOfWork //IUnitOfWork
    {
        private readonly IUserRepository userRepository;

        private readonly IRoleRepository roleRepository;

        private readonly ICandidateRepository candidateRepository;

        private readonly IEmployeeRepository employeeRepository;

        private readonly IVacancyRepository vacancyRepository;

        private readonly ISession session;

        public UnitOfWork()
        {

        }
        public void Dispose()
        {
            
        }
    }
}
