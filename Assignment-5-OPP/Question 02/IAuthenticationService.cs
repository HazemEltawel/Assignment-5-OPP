using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_OPP.Question_02
{
    public interface IAuthenticationService
    {
        bool Authenticate(string username, string password);
        bool Authenticate(string? username, object password);
        bool Register(string username, string role);

    }
}
