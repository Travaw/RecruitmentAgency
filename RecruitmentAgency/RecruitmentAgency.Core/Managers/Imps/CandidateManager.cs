using System;
using System.Collections.Generic;
using System.Linq;

using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Repositories;

namespace RecruitmentAgency.Core.Managers.Imps
{
    /// <summary>
    /// Менеджер сущности <see cref="Candidate"/>
    /// </summary>
    public class CandidateManager: ManagerBase<ICandidateRepository, Candidate, int>, ICandidateManager
    {
        private readonly IUserRepository userRepository;
        public CandidateManager(IUserRepository userRepository, ICandidateRepository candidateRepository) : base(candidateRepository)
        {
            this.userRepository = userRepository;
        }

        /// <inheritdoc/>
        public override Candidate Create(Candidate candidate)
        {
            return base.Create(candidate);
        }

        /// <inheritdoc/>
        public Candidate GetByUser(int id)
        {
            return repository.Get(c => c.User.Id == id);
        }

        /// <inheritdoc/>
        public Candidate GetByUser(string login)
        {
            return repository.Get(c => c.User.Login == login);
        }

        /// <inheritdoc/>
        public ICollection<Candidate> Search(Func<Candidate, bool> predicate)
        {
            return repository.Search(predicate).ToList();
        }

        /// <inheritdoc/>
        public ICollection<Candidate> Search(int? experience, string professionalField, string skills)
        {
            return repository.Search(experience, professionalField, skills).ToList();
        }
    }
}
