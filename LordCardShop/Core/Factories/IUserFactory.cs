using LOrdCardShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOrdCardShop.Core.Factories
{
    public interface IUserFactory
    {
        User CreateUser(string username, string email, string password, string gender);
    }
}