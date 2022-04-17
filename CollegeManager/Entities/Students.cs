namespace CollegeServer.Entities
{
    public class Students
    {
        public int Id { get; set; }
        public Users User { get; set; }
        public Groups Group { get; set; }

        public Students(int id, Users user, Groups group)
        {
            Id = id;
            User = user;
            Group = group;
        }
    }
}
