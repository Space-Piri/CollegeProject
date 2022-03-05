using CollegeServer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeServer.Repositories
{
    public class TeachersRepository : Repository
    {
        public static Teachers GetTeachersById(int Id)
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from Teachers where Id  = " + Id, cn);
            var reader = cmd.ExecuteReader();
            Teachers teacherS = null;
            while (reader.Read())
            {
                teacherS = new
            }
        }
    }
}
