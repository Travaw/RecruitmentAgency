using AutoMapper;
using System.Collections.Generic;

using RecruitmentAgency.Api.Services.DTOs;
using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Managers;

namespace RecruitmentAgency.Api.Services.Imps
{
    /// <summary>
    /// Сервис для работы с ролями пользователей
    /// </summary>
    public class RolleAppService:IRoleAppService
    {
        private readonly IRoleManager roleManager;

        private readonly IMapper mapper;

        public RolleAppService(IRoleManager roleManager, IMapper mapper)
        {
            this.roleManager = roleManager;
            this.mapper = mapper;
        }

        /// <inheritdoc/>
        public RoleDTO Create(RoleDTO createRoleDTO)
        {
            var role = mapper.Map<Role>(createRoleDTO);
            var entity = roleManager.Create(role);
            return mapper.Map<RoleDTO>(entity);
        }

        /// <inheritdoc/>
        public RoleDTO Update(RoleDTO updateRoleDTO)
        {
            var role = mapper.Map<Role>(updateRoleDTO);
            var entity = roleManager.Update(role);
            return mapper.Map<RoleDTO>(entity);
        }

        /// <inheritdoc/>
        public RoleDTO Get(int id)
        {
            var entity = roleManager.Get(id);
            return mapper.Map<RoleDTO>(entity);
        }

        /// <inheritdoc/>
        public RoleDTO Get(string roleName)
        {
            var entity = roleManager.Get(roleName);
            return mapper.Map<RoleDTO>(entity);
        }

        /// <inheritdoc/>
        public ICollection<RoleDTO> GetAll()
        {
            return mapper.Map<ICollection<RoleDTO>>(roleManager.GetAll());
        }

        /// <inheritdoc/>
        public void Delete(int id)
        {
            roleManager.Delete(id);
        }
    }
}
