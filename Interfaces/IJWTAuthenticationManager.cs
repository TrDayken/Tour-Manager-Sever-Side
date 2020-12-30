using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tour_Manager_Sever_Side.Interfaces
{
    interface IJWTAuthenticationManager
    {
        Model.UserToken Authenticate(string username, string password);
    }
}
