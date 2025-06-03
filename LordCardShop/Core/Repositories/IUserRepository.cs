using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Core.Repositories
{
    public interface IUserRepository
    {
        User GetUserByUsernameAndPassword(string username, string password);
        User GetUserByUsername(string username);
        User GetUserById(int id);
        List<User> GetAllUsers();
        void InsertUser(User user);
    }
}