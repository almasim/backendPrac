using Microsoft.AspNetCore.Mvc;
using studentproject.Models;
using studentproject.Services;
using System.Collections.Generic;

namespace studentproject.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class StudentController : Controller
    {
        private readonly StudentService studentService;

        public StudentController(StudentService studentService)
        {
            this.studentService = studentService;
        }


        [HttpGet]        
            public IEnumerable<Student> GetAllStudents()
        {
            return studentService.GetAllStudent();   
        }


        [HttpGet]
        [Route("{id}")]
        public Student GetStudentsById(int id)
        {
            return studentService.GetStudentByEmail(id);
        }

    }
}
