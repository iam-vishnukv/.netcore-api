using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Core.Entity;
using TestProject.Core.Interfaces;
using TestProject.Service.Exception;

namespace TestProject.Infrastrure.Repository
{
   public class UserRepository : IUserRepository
    {
        public bool AddUser(User user)
        {
            try
            {
                return true;

            }
            catch (ServerException ex)
            {
                throw ex;
            }
        }

        public User GetUserById(string userId)
        {
            try
            {
                return new User();

            }
            catch (ServerException ex)
            {
                throw ex;
            }
        }

        public List<User> GetUsersListByFilter(User user)
        {
            try
            {
                return new List<User>();

            }
            catch (ServerException ex)
            {
                throw ex;
            }
        }

        public bool UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
