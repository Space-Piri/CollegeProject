using CollegeServer.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CollegeServer.Repositories
{
    public class TeacherCourseRepository : Repository
    {
        public static async Task<List<TeacherCourse>> GetTeacherCourses()
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from TeacherCourse", cn);
            var reader = cmd.ExecuteReader();
            List<TeacherCourse> teacherCourse = new List<TeacherCourse>();
            while (reader.Read())
            {
                teacherCourse.Add(new TeacherCourse(Convert.ToInt32(reader["Id"]), TeachersRepository.GetTeachersById(Convert.ToInt32(reader["Id_Teacher"])), await CoursesRepository.GetCourseById(Convert.ToInt32(reader["Id_Course"])), Convert.ToInt32(reader["Progress"]), Convert.ToBoolean(reader["Certificate"])));
            }
            await cn.CloseAsync();
            return teacherCourse;
        }

        public static async Task<TeacherCourse> GetTeacherCourseById(int Id)
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from TeacherCourse where Id = " + Id, cn);
            var reader = cmd.ExecuteReader();
            TeacherCourse teacherCourse = null;
            while (reader.Read())
            {
                teacherCourse = new TeacherCourse(Convert.ToInt32(reader["Id"]), TeachersRepository.GetTeachersById(Convert.ToInt32(reader["Id_Teacher"])), await CoursesRepository.GetCourseById(Convert.ToInt32(reader["Id_Course"])), Convert.ToInt32(reader["Progress"]), Convert.ToBoolean(reader["Certificate"]));
            }
            await cn.CloseAsync();
            return teacherCourse;
        }
    }
}
