using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using RecruitmentAgency.Api.Helpers;
using RecruitmentAgency.Api.Services.DTOs;
using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Managers;

namespace RecruitmentAgency.Api.Services.Imps
{
    /// <summary>
    /// Сервис для работы с кандидатами
    /// </summary>
    public class CandidateAppService : ICandidateAppService
    {
        private readonly ICandidateManager candidateManager;

        private readonly IUserManager userManager;

        private readonly IMapper mapper;

        public CandidateAppService(ICandidateManager candidateManager, IUserManager userManager, IMapper mapper)
        {
            this.candidateManager = candidateManager;
            this.userManager = userManager;
            this.mapper = mapper;
        }

        ///<inheritdoc/>
        public CandidateDTO Create(CreateCandidateDTO createCandidateDTO)
        {            
            var candidate = mapper.Map<Candidate>(createCandidateDTO);
            candidate.User = userManager.Get(createCandidateDTO.UserName);
            var entity = candidateManager.Create(candidate);
            return mapper.Map<CandidateDTO>(entity);
        }

        ///<inheritdoc/>
        public CandidateDTO Update(UpdateCandidateDTO updateCandidateDTO)
        {
            var candidate = candidateManager.Get(updateCandidateDTO.Id);
            candidate.Firstname = updateCandidateDTO.Firstname;
            candidate.Secondname = updateCandidateDTO.Secondname;
            candidate.Patronimic = updateCandidateDTO.Patronimic;
            candidate.Experience = updateCandidateDTO.Experience;
            candidate.ProfessionalField = updateCandidateDTO.ProfessionalField;
            candidate.Skills = updateCandidateDTO.Skills;
            candidate.Photo = updateCandidateDTO.Photo;
            var entity = candidateManager.Update(candidate);
            return mapper.Map<CandidateDTO>(entity);
        }

        ///<inheritdoc/>
        public CandidateDTO Get(int id)
        {
            var entity = candidateManager.Get(id);
            return mapper.Map<CandidateDTO>(entity);
        }

        ///<inheritdoc/>
        public CandidateDTO GetByUser(int id)
        {
            var user = userManager.Get(id);
            var entity = candidateManager.GetByUser(id);
            return mapper.Map<CandidateDTO>(entity);
        }

        ///<inheritdoc/>
        public CandidateDTO GetByUser(string login)
        {
            var entity = candidateManager.GetByUser(login);
            return mapper.Map<CandidateDTO>(entity);
        }

        ///<inheritdoc/>
        public ICollection<CandidateDTO> Search(SearchCandidateDTO search)
        {
            /*Expression<Func<Candidate, bool>> searchFunc = RequestHelper.CreateCandidateLambda(search.Experience, search.ProfessionalField, search.Skills);
            if (searchFunc == null)
            {
                return mapper.Map<ICollection<CandidateDTO>>(candidateManager.GetAll());
            }
            else
            */
            return mapper.Map<ICollection<CandidateDTO>>(candidateManager.Search(search.Experience, search.ProfessionalField, search.Skills));//searchFunc.Compile() );
           // }
        }

        ///<inheritdoc/>
        public ICollection<CandidateDTO> GetAll()
        {
            return mapper.Map<ICollection<CandidateDTO>>(candidateManager.GetAll());
        }

        ///<inheritdoc/>
        public void Delete(int id)
        {
            candidateManager.Delete(id);
        }
    }
}
