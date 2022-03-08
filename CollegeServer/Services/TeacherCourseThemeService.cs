using CollegeServer.Entities;
using System.Data.SqlClient;

namespace CollegeServer.Services
{
    public class TeacherCourseThemeService : Service
    {
        public static void UpdateCourse(TeacherCourseTheme teacherCourseTheme)
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand(string.Format("update TeacherCourseTheme set Id_TeacherCourse = '{0}', Name = '{1}' where Id = " + teacherCourseTheme.Id, teacherCourseTheme.TeacherCourse.Id, teacherCourseTheme.Name), cn);
            var reader = cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
