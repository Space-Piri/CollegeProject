using CollegeServer.Entities;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CollegeServer.Repositories
{
    public class GroupsRepository : Repository
    {
        public static async Task<Groups> GetSGroupById(int Id)
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from Groups where Id = " + Id, cn);
            var reader = cmd.ExecuteReader();
            Groups group = null;
            while (reader.Read())
            {
                group = new Groups(Convert.ToInt32(reader["Id"]), Convert.ToString(reader["Name"]), await SpecialtiesRepository.GetSpecialityById(Convert.ToInt32(reader["Id_Speciality"])));
            }
            await cn.CloseAsync();
            return group;
        }
    }
}
