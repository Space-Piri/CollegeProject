using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeServer
{
    [Route("test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        //GET Test
        [HttpGet]
        public IEnumerable<TestClass> Get()
        {
            List<TestClass> test = new List<TestClass>();
            test.Add(new TestClass(0, "123", "123@mail.ru"));
            test.Add(new TestClass(0, "321", "321@mail.ru"));
            return test;
        }
    }
}
