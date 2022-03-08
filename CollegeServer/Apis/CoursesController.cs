using CollegeServer.Entities;
using CollegeServer.Repositories;
using CollegeServer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CollegeServer.Apis
{
    [Route("courses")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Courses> Get()
        {
            return CoursesRepository.GetCourses();
        }

        [HttpPost]
        public void Post(Courses course)
        {
            CoursesService.AddCourse(course);
        }

        [HttpPut]
        public void Update(Courses course)
        {
            CoursesService.UpdateCourse(course);
        }
    }
}
