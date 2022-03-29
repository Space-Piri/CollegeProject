namespace CollegeServer.Entities
{
    public class Groups
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Specialities Speciality { get; set; }

        public Groups(int id, string name, Specialities speciality)
        {
            Id = id;
            Name = name;
            Speciality = speciality;
        }
    }
}
