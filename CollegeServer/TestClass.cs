using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeServer
{
    public class TestClass
    {
        public int id { get; set; }
        public string login { get; set; }
        public string email { get; set; }

        public TestClass(int id, string login, string email)
        {
            this.id = id;
            this.login = login;
            this.email = email;
        }
    }
}
