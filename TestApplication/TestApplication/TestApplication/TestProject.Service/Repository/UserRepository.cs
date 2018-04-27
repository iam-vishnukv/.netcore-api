using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using TestProject.Core.Entity;
using TestProject.Core.Interfaces;
using TestProject.Infrastrure.Data;
using TestProject.Infrastrure.Exception;

namespace TestProject.Infrastrure.Repository
{
    public class UserRepository : BaseDataAcess, IUserRepository

    {

        public UserRepository() : base()
        {

        }

        public bool AddUser(User user)
        {
            try
            {

                //List<DbParameter> parameterList = new List<DbParameter>();
                //DbParameter TestIdParamter = base.GetParameterOut("bookId", SqlDbType.Int, user.UserId);
                //parameterList.Add(TestIdParamter); 
                //parameterList.Add(base.GetParameter("book", user.UserName));
                //parameterList.Add(base.GetParameter("stock", 1));
                //base.ExecuteNonQuery("insertBook", parameterList);
                //user.UserId = (int)TestIdParamter.Value;

                //if(user.UserId == 0)
                //{
                //    return false;
                //}
                return true;
            }
            catch (ApplicationException ex)
            {
                throw new ServerException(ex.ToString(), ex);
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
                throw new ServerException(ex.ToString(), ex);
            }
        }

        public List<User> GetUsersListByFilter(User user)
        {
            try
            {
                List<User> userList = new List<User>();


                List<DbParameter> parameterList = new List<DbParameter>();

                using (DbDataReader dataReader = base.GetDataReader("getBillById", parameterList, CommandType.StoredProcedure))
                {
                    if (dataReader != null && dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            //userList.Add(new User {
                            //    UserId = (int)dataReader["userId"],
                            //    UserName = dataReader["userName"].ToString()
                            //    });
                        }
                    }
                }
                return userList;

            }
            catch (ServerException ex)
            {
                throw new ServerException(ex.ToString(), ex);
            }
        }

        public bool UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
