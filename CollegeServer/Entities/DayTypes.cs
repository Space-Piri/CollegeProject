namespace CollegeServer.Entities
{
    public class DayTypes
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public DayTypes(int id, string type)
        {
            Id = id;
            Type = type;
        }
    }
}
