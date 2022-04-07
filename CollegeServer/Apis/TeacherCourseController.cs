using CollegeServer.Entities;
using CollegeServer.Repositories;
using CollegeServer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CollegeServer.Apis
{
    [Route("teachercourse")]
    [ApiController]
    public class TeacherCourseController : ControllerBase
    {
        [HttpPost]
        public void Post(TeacherCourse teacherCourse)
        {
            TeacherCourseService.AddTeacherCourse(teacherCourse);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeacherCourse>>> Get()
        {
            return await TeacherCourseRepository.GetTeacherCourses();
        }
    }
}
