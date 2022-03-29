using CollegeServer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CollegeServer.Repositories
{
    public class TeacherCourseRepository : Repository
    {
        public static List<TeacherCourse> GetTeacherCourses()
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from TeacherCourse", cn);
            var reader = cmd.ExecuteReader();
            List<TeacherCourse> teacherCourse = new List<TeacherCourse>();
            while (reader.Read())
            {
                teacherCourse.Add(new TeacherCourse(Convert.ToInt32(reader["Id"]), TeachersRepository.GetTeachersById(Convert.ToInt32(reader["Id_Teacher"])), CoursesRepository.GetCourseById(Convert.ToInt32(reader["Id_Course"])), Convert.ToInt32(reader["Progress"]), Convert.ToBoolean(reader["Certificate"])));
            }
            cn.Close();
            return teacherCourse;
        }

        public static TeacherCourse GetTeacherCourseById(int Id)
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from TeacherCourse where Id = " + Id, cn);
            var reader = cmd.ExecuteReader();
            TeacherCourse teacherCourse = null;
            while (reader.Read())
            {
                teacherCourse = new TeacherCourse(Convert.ToInt32(reader["Id"]), TeachersRepository.GetTeachersById(Convert.ToInt32(reader["Id_Teacher"])), CoursesRepository.GetCourseById(Convert.ToInt32(reader["Id_Course"])), Convert.ToInt32(reader["Progress"]), Convert.ToBoolean(reader["Certificate"]));
            }
            cn.Close();
            return teacherCourse;
        }
    }
}
