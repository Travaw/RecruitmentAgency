using RecruitmentAgency.Core.Entities;
using RecruitmentAgency.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace RecruitmentAgency.Core.Managers.Imps
{
    public class UserManager: ManagerBase<IUserRepository, User, int>, IUserManager
    {
        

        public UserManager(IUserRepository userRepository):base(userRepository)
        {

        }

        public User Get(string login)
        {
            return repository.Get(u => u.Login == login);
        }

        public User Get(string login, string password)
        {
            return repository.Get(u=>u.Login==login&&u.Password==password);
        }

       
    }
}
