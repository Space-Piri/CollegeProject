using CollegeServer.Entities;
using System;
using System.Data.SqlClient;

namespace CollegeServer.Repositories
{
    public class UserTypesRepository : Repository
    {
        public static UserTypes GetUserTypesById(int Id)
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from User_types where Id = " + Id, cn);
            var reader = cmd.ExecuteReader();
            UserTypes userTypes = null;
            while (reader.Read())
            {
                userTypes = new UserTypes(Convert.ToInt32(reader["Id"]), Convert.ToString(reader["Name"]));
            }
            cn.Close();
            return userTypes;
        }
    }
}
