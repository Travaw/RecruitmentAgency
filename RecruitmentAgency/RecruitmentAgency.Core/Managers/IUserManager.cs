using RecruitmentAgency.Core.Entities;
using System.Collections.Generic;

namespace RecruitmentAgency.Core.Managers
{
    public interface IUserManager: IManager<User, int>
    {

        User Get(string login);

        User Get(string login, string password);
    }
}
