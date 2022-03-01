namespace CollegeServer.Entities
{
    public class Disciplines
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Disciplines(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
