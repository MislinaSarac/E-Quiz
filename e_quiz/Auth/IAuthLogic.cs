using System;
using System.Collections.Generic;
using System.Text;

namespace e_quiz
{
    interface IAuthLogic
    {
        bool login(string username, string password, UserTypeEnum userType);
        bool register(string username, string password, UserTypeEnum userType);
    }
}
