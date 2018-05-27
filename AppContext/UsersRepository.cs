using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppContext.Context;
using Models;

namespace AppContext.Respositories
{
    public class UsersRepository : IUsersRepository
    {
        public void AddUser(User user)
        {
            Context.Users.Add(user);
            Context.SaveChanges();
        }

        public void DeleteUse(User user)
        {
            Context.Users.Remove(user);

            Context.SaveChanges();
        }

        public List<User> GetAllUsers()
        {
            return Context.Users.ToList();
        }

        ApplicationContext Context = new ApplicationContext();
    }
}
