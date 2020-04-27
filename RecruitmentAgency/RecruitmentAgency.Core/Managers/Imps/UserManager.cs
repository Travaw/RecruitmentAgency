using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Repositories;

namespace RecruitmentAgency.Core.Managers.Imps
{
    /// <summary>
    /// Менеджер сущности <see cref="User"/>
    /// </summary>
    public class UserManager: ManagerBase<IUserRepository, User, int>, IUserManager
    {       

        public UserManager(IUserRepository userRepository):base(userRepository)
        {

        }

        /// <inheritdoc/>
        public User Get(string login)
        {
            return repository.Get(u => u.Login == login);
        }

        /// <inheritdoc/>
        public User Get(string login, string password)
        {
            return repository.Get(u=>u.Login==login&&u.Password==password);
        }

       
    }
}
