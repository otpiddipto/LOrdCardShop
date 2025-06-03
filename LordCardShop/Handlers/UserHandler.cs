using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LordCardShop.Handlers
{
    public class UserHandler
    {
        UserRepository repository = new UserRepository();

        public bool isUsernameTaken(string username)
        {
            return repository.isUsernameTaken(username);
        }

        public void registerUser(User user)
        {
            repository.insertUser(user);
        }

        public User login(string username, string password)
        {
            return repository.getUser(username, password);
        }

        public void updateProfile(User updatedUser)
        {
            repository.UpdateUser(updatedUser);

        }

        public bool ChangePassword(int userId, string oldPassword, string newPassword)
        {
            var user = repository.GetUserbyID(userId);
            if (user != null)
            {
                user.UserPassword = newPassword;
                repository.UpdateUser(user);
                return true;
            }
            return false;
        }
        public User GetUserByID(int userId)
        {
            return repository.GetUserbyID(userId);
        }
    }
}