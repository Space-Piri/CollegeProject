namespace CollegeServer.Entities
{
    public class TeacherDiscipline
    {
        public int Id { get; set; }
        public Teachers Teacher { get; set; }
        public Disciplines Discipline { get; set; }

        public TeacherDiscipline(int id, Teachers teacher, Disciplines discipline)
        {
            Id = id;
            Teacher = teacher;
            Discipline = discipline;
        }
    }
}
