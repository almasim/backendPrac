using Microsoft.AspNetCore.Mvc;
using schoolASPgrades.Models;
using schoolASPgrades.Services;
using System.Collections.Generic;

namespace schoolASPgrades.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class studentController : Controller
    {
        private readonly schoolService schoolService;
        public studentController(schoolService schoolService)
        {
            this.schoolService = schoolService;
        }

        [HttpGet]
        public IEnumerable<Student> GetAllStudent()
        {
            return schoolService.GetAllStudent();
        }

        [HttpGet]
        [Route("email/{email}")]
        public Student GetStudentByMail(string email)
        {
            return schoolService.GetStudentByEmail(email);
        }

        [HttpGet]
        [Route("{id}")]
        public IEnumerable<Grade> GetGradebyId(int id)
        {
            return schoolService.GetGradesbyId(id);
        }
    }
}
