using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_OPP.Question_02
{
    public class BasicAuthenticationService : IAuthenticationService
    {
        string UserName ="admin";
        string PasswordUser ="123";
        string Role ="admin";
        public bool Authenticate(string username, string password)
        {
            return username == UserName && password == PasswordUser;
        }

        public bool Authenticate(string? username, object password)
        {
            throw new NotImplementedException();
        }

        public bool Register(string username, string role)
        {
            return username == UserName && role == Role;
        }
    }
}
