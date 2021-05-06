using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PESMVC.Auth.Models
{
    public class UserRepository : IDisposable
    {
        UserEntities context = new UserEntities();

        public LoginCredential ValidateAccount(string username, string password)
        {
            return context.LoginCredentials.FirstOrDefault(user =>
            user.loginId.Equals(username, StringComparison.OrdinalIgnoreCase)
            && user.pswd == password);
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}