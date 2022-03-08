using CollegeServer.Entities;
using System.Data.SqlClient;

namespace CollegeServer.Services
{
    public class TeacherCourseService : Service
    {
        public static void AddTeacherCourse(TeacherCourse teacherCourse)
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into TeacherCourse values ('{0}', '{1}', '{2}', '{3}')", teacherCourse.Teacher.Id, teacherCourse.Course.Id, teacherCourse.Progress, teacherCourse.Certificate), cn);
            var reader = cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
