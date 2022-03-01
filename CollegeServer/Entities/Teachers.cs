namespace CollegeServer.Entities
{
    public class Teachers
    {
        public int Id { get; set; }
        public Users User { get; set; }

        public Teachers(int id, Users user)
        {
            Id = id;
            User = user;
        }
    }
}
