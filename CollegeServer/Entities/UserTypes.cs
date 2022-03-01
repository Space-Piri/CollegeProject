namespace CollegeServer.Entities
{
    public class UserTypes
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public UserTypes(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
