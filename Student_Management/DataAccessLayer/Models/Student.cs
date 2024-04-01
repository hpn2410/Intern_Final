using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class Student
    {
        public Student()
        {
            Grades = new HashSet<Grade>();
        }

        public int StudentId { get; set; }
        public string StudentName { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }
    }
}
