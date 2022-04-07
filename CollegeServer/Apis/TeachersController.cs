using CollegeServer.Entities;
using CollegeServer.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CollegeServer.Apis
{
    [Route("teachers")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Teachers> Get()
        {
            return TeachersRepository.GetTeachers();
        }
    }
}
