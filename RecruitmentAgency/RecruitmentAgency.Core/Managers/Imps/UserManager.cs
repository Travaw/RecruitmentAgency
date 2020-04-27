using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Repositories;

namespace RecruitmentAgency.Core.Managers.Imps
{
    /// <summary>
    /// Менеджер сущности <see cref="User"/>
    /// </summary>
    public class UserManager: ManagerBase<IUserRepository, User, int>, IUserManager
    {
        private const string entityName = "User";

        public UserManager(IUserRepository userRepository):base(userRepository)
        {

        }

        /// <inheritdoc/>
        public User Get(string login)
        {
            var user = repository.Get(u => u.Login == login);
            return user;
        }

        /// <inheritdoc/>
        public User Get(string login, string password)
        {
            var user = repository.Get(u=>u.Login==login&&u.Password==password);
            return user;
        }

       
    }
}
