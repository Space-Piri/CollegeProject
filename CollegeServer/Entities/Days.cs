using System;

namespace CollegeServer.Entities
{
    public class Days
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Groups Group { get; set; }
        public DayTypes DayType { get; set; }

        public Days(int id, DateTime date, Groups group, DayTypes dayType)
        {
            Id = id;
            Date = date;
            Group = group;
            DayType = dayType;
        }
    }
}
