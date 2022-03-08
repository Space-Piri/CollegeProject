using CollegeServer.Entities;
using CollegeServer.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CollegeServer.Apis
{
    [Route("users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Users> Get()
        {
            return UserRepository.GetUsers();
        }
    }
}
