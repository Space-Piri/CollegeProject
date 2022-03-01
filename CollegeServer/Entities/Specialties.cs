namespace CollegeServer.Entities
{
    public class Specialities
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Specialities(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
