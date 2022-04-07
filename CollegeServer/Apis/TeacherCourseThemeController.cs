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
        public async Task<ActionResult<IEnumerable<TeacherCourseTheme>>> Get(int Id)
        {
            var themes = await TeacherCourseThemeRepository.GetTeacherCourseThemesById(Id);
            return themes;
        }

        [HttpPut]
        public void Update(TeacherCourseTheme teacherCourseTheme)
        {
            TeacherCourseThemeService.UpdateTeacherCourseTheme(teacherCourseTheme);
        }

        [HttpPost]
        public void Add(TeacherCourseTheme teacherCourseTheme)
        {
            TeacherCourseThemeService.AddTeacherCourseTheme(teacherCourseTheme);
        }
    }
}
