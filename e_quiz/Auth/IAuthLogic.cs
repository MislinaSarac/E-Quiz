using System;
using System.Collections.Generic;
using System.Text;

namespace e_quiz
{
    interface IAuthLogic
    {
        bool login(string Username, string Password, UserTypeEnum userType);
        bool register(string Username, string Password, UserTypeEnum userType);
    }
}
