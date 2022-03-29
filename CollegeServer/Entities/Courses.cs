using System;

namespace CollegeServer.Entities
{
    public class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TargetHours { get; set; }
        public int PassedHours { get; set; }
        public string Location { get; set; }

        public Courses(int id, string name, string location, DateTime startDate, DateTime endDate, int targetHours, int passedHours)
        {
            Id = id;
            Name = name;
            Location = location;
            StartDate = startDate;
            EndDate = endDate;
            TargetHours = targetHours;
            PassedHours = passedHours;
        }
    }
}
