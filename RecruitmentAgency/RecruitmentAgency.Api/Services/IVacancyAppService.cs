using RecruitmentAgency.Api.Services.DTOs;
using System.Collections.Generic;

namespace RecruitmentAgency.Api.Services
{
    public interface IVacancyAppService : ICommonAppService<VacancyDTO, CreateVacancyDTO, UpdateVacancyDTO>
    {
        ICollection<VacancyDTO> Search(SearchVacancyDTO search);
        ICollection<VacancyDTO> GetAllForUser(string userName);

        void SwitchActive(int id);
    }
}
