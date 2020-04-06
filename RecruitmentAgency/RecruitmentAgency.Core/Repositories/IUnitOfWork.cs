using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitmentAgency.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository();

        IRoleRepository RoleRepository();

        ICandidateRepository CandidateRepository();

        IEmployeeRepository EmployeeRepository();

        IVacancyRepository VacancyRepository();
    }
}
