using NHibernate;
using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Repositories;

namespace RecruitmentAgency.NHibernate.Repositories
{
    /// <summary>
    /// Репозиторий сущности <see cref="Employee"/>
    /// </summary>
    public class EmployeeRepository:NHRepository<Employee, int>, IEmployeeRepository
    {
        public EmployeeRepository(ISession session) : base(session)
        {

        }
    }
}
