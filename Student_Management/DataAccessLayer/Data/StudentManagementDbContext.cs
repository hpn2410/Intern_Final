using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data
{
    public class StudentManagementDbContext : DbContext
    {
        public StudentManagementDbContext
            (DbContextOptions<StudentManagementDbContext> options) 
            : base(options) { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Subject_Class> Subject_Classes { get; set; }
        public DbSet<Instructor_Class> Instructor_Classes { get; set; }
    }
}
