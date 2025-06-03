using LordCardShop.Factories;
using LordCardShop.Handlers;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace LordCardShop.Controllers
{
    public class UserController
    {

        UserHandler UserHandler = new UserHandler();
        UserFactory UserFactory = new UserFactory();
        public  string ValidateRegistration(string username, string email, string password, string confirmPassword, string gender)
        {
            if (string.IsNullOrWhiteSpace(username) || username.Length < 5 || username.Length > 30 || !Regex.IsMatch(username, @"^[a-zA-Z\s]+$"))
                return "Username must be 5-30 characters and contain only letters and spaces.";

            if (!email.Contains("@"))
                return "Email must contain '@'.";

            if (password.Length < 8 || !Regex.IsMatch(password, @"^(?=.*[a-zA-Z])(?=.*\d).+$"))
                return "Password must be at least 8 characters and alphanumeric.";

            if (password != confirmPassword)
                return "Password confirmation does not match.";

            if (string.IsNullOrEmpty(gender))
                return "Gender must be selected.";

            if (UserHandler.isUsernameTaken(username))
                return "Username is already taken.";

            return "";
        }

        public  bool RegisterUser(string username, string email, string password, string gender)
        {
            var user = UserFactory.CreateUser(username, email, password, gender, DateTime.Now); // DOB optional
            UserHandler.registerUser(user);
            return true;
        }

        public  User Login(string username, string password)
        {
            return UserHandler.login(username, password);
        }

        public string ValidateProfileUpdate(string username, string email, string gender)
        {
            if (username.Length < 5 || username.Length > 30 || !Regex.IsMatch(username, @"^[a-zA-Z\s]+$"))
                return "Invalid username.";

            if (!email.Contains("@"))
                return "Invalid email.";

            if (string.IsNullOrEmpty(gender))
                return "Gender is required.";

            return "";
        }

        public static string ValidatePasswordChange(string oldPwd, string newPwd, string confirmPwd, string currentPwd)
        {
            if (oldPwd != currentPwd)
                return "Old password is incorrect.";

            if (newPwd.Length < 8 || !Regex.IsMatch(newPwd, @"^(?=.*[a-zA-Z])(?=.*\d).+$"))
                return "New password must be at least 8 characters and alphanumeric.";

            if (newPwd != confirmPwd)
                return "New password and confirmation do not match.";

            return "";
        }

        public  void UpdateProfile(User updatedUser)
        {
            UserHandler.updateProfile(updatedUser);
        }
    }

}