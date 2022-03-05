using CollegeServer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeServer.Repositories
{
    public class UserRepository : Repository
    {
        public static List<Users> GetUsers()
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from Users", cn);
            var reader = cmd.ExecuteReader();
            List<Users> userS = null;
            while (reader.Read())
            {
                userS.Add(new Users(Convert.ToInt32(reader["Id"]), Convert.ToString(reader["FIO"]), UserTypesRepository.GetUserTypesById(Convert.ToInt32(reader["Id_Type"])), Convert.ToString(reader["Login"]), Convert.ToString(reader["Password"])));
            }

            cn.Close();
            return userS;
        }
    }
}
