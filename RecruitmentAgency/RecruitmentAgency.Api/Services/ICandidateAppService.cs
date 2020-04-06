using RecruitmentAgency.Api.Services.DTOs;
using System.Collections.Generic;

namespace RecruitmentAgency.Api.Services
{
    public interface ICandidateAppService : ICommonAppService<CandidateDTO, CreateCandidateDTO, UpdateCandidateDTO>
    {
        CandidateDTO GetByUser(int id);

        CandidateDTO GetByUser(string login);

        ICollection<CandidateDTO> Search(SearchCandidateDTO search);
    }
}
