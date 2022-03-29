using CollegeServer.Entities;
using CollegeServer.Repositories;
using CollegeServer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        public IEnumerable<TeacherCourse> Get()
        {
            return TeacherCourseRepository.GetTeacherCourses();
        }
    }
}
