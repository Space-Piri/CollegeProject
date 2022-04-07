using CollegeServer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CollegeServer.Repositories
{
    public class CoursesRepository : Repository
    {
        public static async Task<List<Courses>> GetCourses()
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from Courses", cn);
            var reader = cmd.ExecuteReader();
            List<Courses> courses = new List<Courses>();
            while (reader.Read())
            {
                courses.Add(new Courses(Convert.ToInt32(reader["Id"]), Convert.ToString(reader["Name"]), Convert.ToString(reader["Location"]), Convert.ToDateTime(reader["Start_Date"]), Convert.ToDateTime(reader["End_Date"]), Convert.ToInt32(reader["Target_Hours"]), Convert.ToInt32(reader["Passed_Hours"])));
            }
            await cn.CloseAsync();
            return courses;
        }

        public static async Task<Courses> GetCourseById(int Id)
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from Courses where Id = " + Id, cn);
            var reader = cmd.ExecuteReader();
            Courses course = null;
            while (reader.Read())
            {
                course = new Courses(Convert.ToInt32(reader["Id"]), Convert.ToString(reader["Name"]), Convert.ToString(reader["Location"]), Convert.ToDateTime(reader["Start_Date"]), Convert.ToDateTime(reader["End_Date"]), Convert.ToInt32(reader["Target_Hours"]), Convert.ToInt32(reader["Passed_Hours"]));
            }
            await cn.CloseAsync();
            return course;
        }
    }
}
