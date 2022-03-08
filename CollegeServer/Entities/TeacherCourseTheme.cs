namespace CollegeServer.Entities
{
    public class TeacherCourseTheme
    {
        public int Id { get; set; }
        public TeacherCourse TeacherCourse { get; set; }
        public string Name { get; set; }

        public TeacherCourseTheme(int id, TeacherCourse teacherCourse, string name)
        {
            Id = id;
            TeacherCourse = teacherCourse;
            Name = name;
        }
    }
}
