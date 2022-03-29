using CollegeServer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CollegeServer.Services
{
    public class CoursesService : Service
    {
        public static void AddCourse(Courses course)
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into Courses values ('{0}', '{1}', '{2}', '{3}', {4}, {5})", course.Name, course.Location, course.StartDate, course.EndDate, course.TargetHours, course.PassedHours), cn);
            var reader = cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static void UpdateCourse(Courses course)
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand(string.Format("update Courses set Name = '{0}', Location = '{1}', Start_Date = '{2}', End_Date = '{3}', Target_Hours = {4}, Passed_Hours = {5} where Id = " + course.Id, course.Name, course.Location, course.StartDate, course.EndDate, course.TargetHours, course.PassedHours), cn);
            var reader = cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
