using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LOrdCardShop.Core.Repositories;
using LOrdCardShop.Model;

namespace LOrdCardShop.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly LOrdCardShopDBEntities1 db = new LOrdCardShopDBEntities1();

        public User GetUserByUsernameAndPassword(string username, string password)
        {
            return db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        public User GetUserByUsername(string username)
        {
            return db.Users.FirstOrDefault(u => u.Username == username);
        }

        public User GetUserById(int id)
        {
            return db.Users.FirstOrDefault(u => u.UserID == id);
        }

        public List<User> GetAllUsers()
        {
            return db.Users.ToList();
        }

        public void InsertUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }
    }
}