using RecruitmentAgency.Core.Entities;
using System;
using System.Collections.Generic;

namespace RecruitmentAgency.Core.Managers
{
    public interface ICandidateManager :IManager<Candidate, int>
    {
        Candidate GetByUser(int id);

        Candidate GetByUser(string login);

        ICollection<Candidate> Search(Func<Candidate, bool> search);
    }
}
