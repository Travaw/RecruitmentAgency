using RecruitmentAgency.Api.Services.DTOs;

namespace RecruitmentAgency.Api.Services
{
    public interface IEmployeeAppService : ICommonAppService<EmployeeDTO, CreateEmployeeDTO, UpdateEmployeeDTO>
    {
        EmployeeDTO GetByUser(string login);
    }
}
