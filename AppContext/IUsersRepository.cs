using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppContext
{
    public interface IUsersRepository
    {

        void AddUser(User user);

        void DeleteUse(User user);

        List<User> GetAllUsers();
    }
}
