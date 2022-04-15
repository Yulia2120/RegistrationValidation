using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using RegistrationValidation.Model;

namespace RegistrationValidation.Controller
{
    public class RegistrationController
    {
        public RegistrationController() { }
        public void Registration(string _name, string _email, string _pass)
        {

            using (SqlConnection connection = new SqlConnection(SqlConnectionClass.ConnectionString))
            {
                UsersL registration = new UsersL() { Name = _name, Email = _email, Password = new TextCrypt().Generate(_pass) };
                connection.Execute("sp_Registr", registration, commandType: CommandType.StoredProcedure);
              
            }

        }
    }
}
