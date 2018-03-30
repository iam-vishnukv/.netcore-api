using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Core.Entity;
namespace TestProject.Core.Interfaces
{
   public  interface IUserRepository
    {
        bool AddUser(User user);
        bool UpdateUser(User user);
        List<User> GetUsersListByFilter(User user);
        User GetUserById(string userId);


    }
}
