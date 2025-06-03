
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LordCardShop.Handlers
{
    public class UserRepository
    {
        LOrdCardShopDatabaseEntities db = new LOrdCardShopDatabaseEntities();

        public  bool isUsernameTaken(string username)
        {
            return db.Users.Any(u => u.UserName == username);
        }


        public  void insertUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public User getUser(string username, string password)
        {
            
                return db.Users.FirstOrDefault(u => u.UserName == username && u.UserPassword == password);
                
            
        }

        public User GetUserbyID(int userId)
        {

            return db.Users.FirstOrDefault(u => u.UserId == userId);


        }

        public  void UpdateUser(User updatedUser)
        {
            
            
                var user = db.Users.Find(updatedUser.UserId);
                if (user != null)
                {
                    user.UserName = updatedUser.UserName;
                    user.UserEmail = updatedUser.UserEmail;
                    user.UserPassword = updatedUser.UserPassword;
                    user.UserGender = updatedUser.UserGender;
                    user.UserDOB = updatedUser.UserDOB;
                    user.UserRole = updatedUser.UserRole;
                    db.SaveChanges();
                }
            
        }

       
    }
}