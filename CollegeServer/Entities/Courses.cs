using System;

namespace CollegeServer.Entities
{
    public class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public int Target_Hours { get; set; }
        public int Passed_Hours { get; set; }

        public Courses(int id, string name, DateTime start_Date, DateTime end_Date, int target_Hours, int passed_Hours)
        {
            Id = id;
            Name = name;
            Start_Date = start_Date;
            End_Date = end_Date;
            Target_Hours = target_Hours;
            Passed_Hours = passed_Hours;
        }
    }
}
