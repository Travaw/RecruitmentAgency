using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;

using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Repositories;


namespace RecruitmentAgency.NHibernate.Repositories
{
    /// <summary>
    /// Репозиторий сущности <see cref="Candidate"/>
    /// </summary>
    public class CandidateRepository : NHRepository<Candidate, int>, ICandidateRepository
    {
        public CandidateRepository(ISession session): base(session)
        {            
        }

        /// <inheritdoc/>
        public ICollection<Candidate> Search(int? experience, string professionalField, string skills)
        {
            var request = GetAll();
            if (experience != null)
            {
                request = request.Where(v => v.Experience == experience);
            }
            if (professionalField != null && professionalField != " ")
            {
                request = request.Where(v => v.ProfessionalField == professionalField);
            }
            if(skills != null && skills != " ")
            {
                string[] keyWords = skills.Trim(new Char[] { ',', '.', '!', '?' }).ToLower().Split(' ');
                foreach (var keyWord in keyWords)
                    request = request.Where(v => v.Skills.Contains(keyWord));
            }
            return request.ToList();
        }
    }
}
