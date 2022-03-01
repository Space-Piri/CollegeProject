namespace CollegeServer.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public UserTypes Type { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public Users(int id, string fIO, UserTypes type, string login, string password)
        {
            Id = id;
            FIO = fIO;
            Type = type;
            Login = login;
            Password = password;
        }
    }
}
