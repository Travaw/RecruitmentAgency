using RecruitmentAgency.Api.Services;
using RecruitmentAgency.Api.Services.DTOs;
using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace RecruitmentAgency.Web.Providers
{
    /// <summary>
    /// Провайдер ролей пользователя
    /// </summary>
    public class UserRoleProvider : RoleProvider
    {
        private readonly IUserAppService userService;

        private readonly IRoleAppService roleService;

        /// <summary>
        /// Инициализация экземпляра <see cref="UserRoleProvider"/>
        /// </summary>
        public UserRoleProvider()
        {
            this.userService = DependencyResolver.Current.GetService<IUserAppService>();
            this.roleService = DependencyResolver.Current.GetService<IRoleAppService>();
        }        

        /// <inheritdoc/>
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <inheritdoc/>
        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override string[] GetAllRoles()
        {
            return roleService.GetAll().Select(r => r.Name).ToArray();
        }

        /// <inheritdoc/>
        public override string[] GetRolesForUser(string username)
        {
            UserDTO user = userService.Get(username);
            string role = user.Role.Name;
            return new string[] { role };
        }

        /// <inheritdoc/>
        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override bool IsUserInRole(string username, string roleName)
        {
            
            UserDTO user = userService.Get(username);
            return user.Role.Name == roleName ? true : false;

            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override bool RoleExists(string roleName)
        {

            return roleService.Get(roleName) != null ? true : false;
        }
    }
}