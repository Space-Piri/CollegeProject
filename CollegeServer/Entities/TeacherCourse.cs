namespace CollegeServer.Entities
{
    public class TeacherCourse
    {
        public int Id { get; set; }
        public Teachers Teacher { get; set; }
        public Courses Course { get; set; }
        public int Progress { get; set; }
        public bool Certificate { get; set; }

        public TeacherCourse(int id, Teachers teacher, Courses course, int progress, bool certificate)
        {
            Id = id;
            Teacher = teacher;
            Course = course;
            Progress = progress;
            Certificate = certificate;
        }
    }
}
