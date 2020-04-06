using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RecruitmentAgency.Core.Managers.Imps
{
    public class CandidateManager: ManagerBase<ICandidateRepository, Candidate, int>, ICandidateManager
    {
        private readonly IUserRepository userRepository;
        public CandidateManager(IUserRepository userRepository, ICandidateRepository candidateRepository) : base(candidateRepository)
        {
            this.userRepository = userRepository;
        }

        public override Candidate Create(Candidate candidate)
        {
            return base.Create(candidate);
        }
        public Candidate GetByUser(int id)
        {
            return repository.Get(c => c.User.Id == id);
        }

        public Candidate GetByUser(string login)
        {
            return repository.Get(c => c.User.Login == login);
        }

        public ICollection<Candidate> Search(Func<Candidate, bool> predicate)
        {
            return repository.Search(predicate).ToList();
        }
    }
}
