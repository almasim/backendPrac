using Microsoft.EntityFrameworkCore;
using studentproject.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace studentproject.Services
{
    public class StudentService
    {
        private readonly schoolContext context;
        public StudentService(schoolContext context)
        {
            this.context = context;
            context.ChangeTracker.LazyLoadingEnabled = false;
        }
        public IEnumerable<Student> GetAllStudent() { return context.Students.Include(student => student.Subjects);
        }
        public Student GetStudentByEmail(int id) {
            return context.Students.Include(s => s.Subjects).First(s => s.Id == id);
            //return context.Students.First(student => student.Id == id);
        }
    }
}
