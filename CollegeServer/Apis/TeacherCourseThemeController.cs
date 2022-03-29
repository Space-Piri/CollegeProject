using CollegeServer.Entities;
using CollegeServer.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using CollegeServer.Services;

namespace CollegeServer.Apis
{
    [Route("course/themes")]
    [ApiController]
    public class TeacherCourseThemeController : ControllerBase
    {
        [HttpGet("{id}")]
        public IEnumerable<TeacherCourseTheme> Get(int Id)
        {
            return TeacherCourseThemeRepository.GetTeacherCourseThemes().Where(t => t.TeacherCourse.Course.Id == Id);
        }

        [HttpPut]
        public void Update(TeacherCourseTheme teacherCourseTheme)
        {
            TeacherCourseThemeService.UpdateCourse(teacherCourseTheme);
        }
    }
}
