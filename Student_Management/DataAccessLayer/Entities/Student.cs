using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Student
    {
        public int Student_Id { get; set; }
        public string Student_Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public ICollection<Grade> Grades { get; set; }
        public Student()
        {
            Grades = new HashSet<Grade>();
        }
    }
}
