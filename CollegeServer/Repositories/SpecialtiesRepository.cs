using CollegeServer.Entities;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CollegeServer.Repositories
{
    public class SpecialtiesRepository : Repository
    {
        public static async Task<Specialities> GetSpecialityById(int Id)
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from Speciality where Id = " + Id, cn);
            var reader = cmd.ExecuteReader();
            Specialities speciality = null;
            while (reader.Read())
            {
                speciality = new Specialities(Convert.ToInt32(reader["Id"]), Convert.ToString(reader["Name"]));
            }
            await cn.CloseAsync();
            return speciality;
        }
    }
}
