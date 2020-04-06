using RecruitmentAgency.Api.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecruitmentAgency.Api.Services
{
    public interface IUserAppService: ICommonAppService<UserDTO, CreateUserDTO, UpdateUserDTO>
    {
        UserDTO Get(string login);
        UserDTO Get(string login, string password);
    }
}
