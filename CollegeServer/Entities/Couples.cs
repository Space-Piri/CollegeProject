using System;

namespace CollegeServer.Entities
{
    public class Couples
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public Disciplines Discipline { get; set; }
        public Groups Group { get; set; }

        public Couples(int id, int number, DateTime date, Disciplines discipline, Groups group)
        {
            Id = id;
            Number = number;
            Date = date;
            Discipline = discipline;
            Group = group;
        }
    }
}
