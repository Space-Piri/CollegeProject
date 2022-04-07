using CollegeServer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CollegeServer.Repositories
{
    public class TeacherCourseThemeRepository : Repository
    {
        public static async Task<List<TeacherCourseTheme>> GetTeacherCourseThemesById(int Id)
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from TeacherCourseTheme join TeacherCourse on TeacherCourse.Id = TeacherCourseTheme.Id_TeacherCourse where Id_Course = " + Id, cn);
            var reader = cmd.ExecuteReader();
            List<TeacherCourseTheme> teacherCourseTheme = new List<TeacherCourseTheme>();
            while (reader.Read())
            {
                teacherCourseTheme.Add(new TeacherCourseTheme(Convert.ToInt32(reader["Id"]), await TeacherCourseRepository.GetTeacherCourseById(Convert.ToInt32(reader["Id_TeacherCourse"])), Convert.ToString(reader["Name"])));
            }
            await cn.CloseAsync();
            return teacherCourseTheme;
        }

        public static async Task<List<TeacherCourseTheme>> GetTeacherCourseThemes()
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from TeacherCourseTheme", cn);
            var reader = cmd.ExecuteReader();
            List<TeacherCourseTheme> teacherCourseTheme = new List<TeacherCourseTheme>();
            while (reader.Read())
            {
                teacherCourseTheme.Add(new TeacherCourseTheme(Convert.ToInt32(reader["Id"]), await TeacherCourseRepository.GetTeacherCourseById(Convert.ToInt32(reader["Id_TeacherCourse"])), Convert.ToString(reader["Name"])));
            }
            await cn.CloseAsync();
            return teacherCourseTheme;
        }
    }
}
