using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace e_quiz
{
    class AuthLogic : IAuthLogic
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-71BP9LD\\SQLEXPRESS;Initial Catalog=tutorialdb;Integrated Security=True");

        public bool login(string username, string password, UserTypeEnum userType)
        {
            con.Open();
            string commandText = "SELECT * FROM Users WHERE Username=@username AND Password=@password AND UserType = @type";
            SqlCommand command = new SqlCommand(commandText, con);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@type", (int)userType);
            SqlDataReader reader = command.ExecuteReader();
            bool result = reader.Read();
            con.Close();
            return result;
        }

        public bool register(string Username, string Password, UserTypeEnum userType)
        {
            throw new NotImplementedException();
        }
    }
}
