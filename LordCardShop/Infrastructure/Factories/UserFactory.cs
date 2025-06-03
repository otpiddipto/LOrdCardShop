using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LOrdCardShop.Core.Factories;
using LOrdCardShop.Model;


namespace LOrdCardShop.Infrastructure.Factories
{
    public class UserFactory : IUserFactory
    {
        public User CreateUser(string username, string email, string password, string gender)
        {
            return new User
            {
                Username = username,
                Email = email,
                Password = password,
                Gender = gender,
                Role = "Customer" 
            };
        }
    }
}