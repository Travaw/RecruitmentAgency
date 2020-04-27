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
        public override IQueryable<Candidate> GetAll()
        {
            return session.Query<Candidate>().Select(r => new Candidate() { Id = r.Id, Firstname = r.Firstname, Secondname = r.Secondname, Patronimic = r.Patronimic, Experience = r.Experience, Skills = r.Skills, ProfessionalField = r.ProfessionalField });
        }

        /// <inheritdoc/>
        public ICollection<Candidate> Search(int? experience, string professionalField, string skills)
        {
            var request = session.Query<Candidate>();
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
            return request.Select(r => new Candidate() { Id = r.Id, Firstname = r.Firstname, Secondname = r.Secondname, Patronimic = r.Patronimic, Experience=r.Experience, Skills=r.Skills, ProfessionalField=r.ProfessionalField }).ToList();
        }
    }
}
