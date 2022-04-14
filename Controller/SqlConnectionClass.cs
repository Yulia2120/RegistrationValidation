using System;
using System.Collections.Generic;
using System.Configuration;


namespace RegistrationValidation.Controller
{
    public class SqlConnectionClass
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["ContactDB"].ConnectionString;
    }
}
