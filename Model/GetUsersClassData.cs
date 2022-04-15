using Dapper;
using RegistrationValidation.Controller;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace RegistrationValidation.Model
{
    public static class GetUsersClassData
    {
        public static IList<UsersL> GetUsersL()
        {
            using (IDbConnection db = new SqlConnection(SqlConnectionClass.ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<UsersL>("sp_UsersL", commandType: CommandType.StoredProcedure).ToList();
            }
        }
      
    }
}
