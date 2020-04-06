using AutoMapper;
using System.Collections.Generic;

using RecruitmentAgency.Api.Services.DTOs;
using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Managers;

namespace RecruitmentAgency.Api.Services.Imps
{
    public class UserAppService : IUserAppService
    {
        private readonly IUserManager userManager;

        private readonly IRoleManager roleManager;

        private readonly IMapper mapper;

        public UserAppService(IUserManager userManager, IRoleManager roleManager, IMapper mapper)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.mapper = mapper;
        }

        public UserDTO Create(CreateUserDTO createUserDTO)
        {
            var role = roleManager.Get(createUserDTO.RoleId);
            var user = mapper.Map<User>(createUserDTO);
            user.Role = role;
            var entity = userManager.Create(user);
            return mapper.Map<UserDTO>(entity);
        }

        public UserDTO Update(UpdateUserDTO updateUserDTO)
        {
            var user = userManager.Get(updateUserDTO.Id);
            user.Email = updateUserDTO.Email;
            var entity = userManager.Update(user);
            return mapper.Map<UserDTO>(entity);
        }

        public UserDTO Get(int id)
        {
            var entity = userManager.Get(id);
            return mapper.Map<UserDTO>(entity);
        }

        public UserDTO Get(string login)
        {
            var entity = userManager.Get(login);
            return mapper.Map<UserDTO>(entity);
        }

        public UserDTO Get(string login, string password)
        {
            var entity = userManager.Get(login, password);
            return mapper.Map<UserDTO>(entity);
        }

        public ICollection<UserDTO> GetAll()
        {
            return mapper.Map<ICollection<UserDTO>>(userManager.GetAll());
        }

        public void Delete(int id)
        {
            userManager.Delete(id);
        }
    }
}
