using CollegeServer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CollegeServer.Repositories
{
    public class TeacherCourseThemeRepository : Repository
    {
        public static List<TeacherCourseTheme> GetTeacherCourseThemesById(int Id)
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from TeacherCourseTheme where Id_TeacherCourse = " + Id, cn);
            var reader = cmd.ExecuteReader();
            List<TeacherCourseTheme> teacherCourseTheme = new List<TeacherCourseTheme>();
            while (reader.Read())
            {
                teacherCourseTheme.Add(new TeacherCourseTheme(Convert.ToInt32(reader["Id"]), TeacherCourseRepository.GetTeacherCourseById(Convert.ToInt32(reader["Id_TeacherCourse"])), Convert.ToString(reader["Name"])));
            }
            cn.Close();
            return teacherCourseTheme;
        }

        public static List<TeacherCourseTheme> GetTeacherCourseThemes()
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from TeacherCourseTheme", cn);
            var reader = cmd.ExecuteReader();
            List<TeacherCourseTheme> teacherCourseTheme = new List<TeacherCourseTheme>();
            while (reader.Read())
            {
                teacherCourseTheme.Add(new TeacherCourseTheme(Convert.ToInt32(reader["Id"]), TeacherCourseRepository.GetTeacherCourseById(Convert.ToInt32(reader["Id_TeacherCourse"])), Convert.ToString(reader["Name"])));
            }
            cn.Close();
            return teacherCourseTheme;
        }
    }
}
