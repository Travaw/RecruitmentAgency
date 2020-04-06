using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitmentAgency.Api.Services
{
    public interface ICommonAppService<DTO, CreateDTO, UpdateDTO>
    {
        DTO Create(CreateDTO createUserDTO);

        DTO Update(UpdateDTO updateUserDTO);

        DTO Get(int id);

        ICollection<DTO> GetAll();

        void Delete(int id);
    }
}
