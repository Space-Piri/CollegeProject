using CollegeServer.Entities;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CollegeServer.Repositories
{
    public class DaysRepository : Repository
    {
        public static async Task<Days> GetDaysByDateAndGroup(DateTime Date, Groups Group)
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from Days where Date > ' " + Date + " ' and Date < '" + Date.AddDays(7) + "' and Id_Group = " + Group.Id, cn);
            var reader = cmd.ExecuteReader();
            Days day = null;
            while (reader.Read())
            {
                day = new Days(Convert.ToInt32(reader["Id"]), Convert.ToDateTime(reader["Date"]), DayTypesRepository.GetDayTypeById(Convert.ToInt32(reader["Id_DayType"])));
            }
            await cn.CloseAsync();
            return day;
        }
    }
}
