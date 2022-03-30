using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using schoolASPgrades.Models;
using System.Collections.Generic;
using System.Linq;

namespace schoolASPgrades.Services
{
    public class schoolService
    {
        private readonly schoolContext context;
        public schoolService(schoolContext context)
        {
            this.context = context;
            context.ChangeTracker.LazyLoadingEnabled = false;
        }

        public IEnumerable<Student> GetAllStudent()
        {
            return context.Students.Include(student => student.Subjects).Include(s=>s.Grades);
        }
        public Student GetStudentByEmail(string email)
        {
            return context.Students.Include(s => s.Subjects).Include(s => s.Grades).First(s => s.Email == email);
        }
        public IEnumerable<Grade> GetGradesbyId(int id)
        {
            return context.Grades.Where(g => g.StudentId == id).ToList();
        }


    }
}
