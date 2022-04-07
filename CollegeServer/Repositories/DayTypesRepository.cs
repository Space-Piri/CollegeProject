using CollegeServer.Entities;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CollegeServer.Repositories
{
    public class DayTypesRepository : Repository
    {
        public static async Task<DayTypes> GetDayTypeById(int Id)
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from DayTypes where Id = " + Id, cn);
            var reader = cmd.ExecuteReader();
            DayTypes dayType = null;
            while (reader.Read())
            {
                dayType = new DayTypes(Convert.ToInt32(reader["Id"]), Convert.ToString(reader["Type"]));
            }
            await cn.CloseAsync();
            return dayType;
        }
    }
}
