using CollegeServer.Entities;
using CollegeServer.Repositories;
using CollegeServer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeServer.Apis
{
    [Route("courses")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Courses>>> Get()
        {
            return await CoursesRepository.GetCourses();
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
