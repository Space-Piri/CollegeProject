using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManager
{
    public class TestObject
    {
        int Id { get; set; }
        string Name { get; set; }
        DateTime Date { get; set; }

        public TestObject(int Id, string Name, DateTime Date)
        {
            this.Id = Id;
            this.Name = Name;
            this.Date = Date;
        }
    }
}
