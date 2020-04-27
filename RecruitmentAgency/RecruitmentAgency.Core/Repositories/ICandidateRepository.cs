using System.Collections.Generic;

using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Domain.Repositories;

namespace RecruitmentAgency.Core.Repositories
{
    /// <summary>
    /// Репозиторий сущности <see cref="Candidate"/>
    /// </summary>
    public interface ICandidateRepository: IRepository<Candidate, int>
    {
        ICollection<Candidate> Search(int? experience, string professionalField, string skills);
    }
}
