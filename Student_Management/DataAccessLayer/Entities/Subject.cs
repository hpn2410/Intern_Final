using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    internal class Subject
    {
        public int Subject_Id { get; set; }
        public string Subject_Code { get; set; }
        public string Subject_Name { get; set; }

        public ICollection<Grade> Grades { get; set; }
        public ICollection<Subject_Class> Subject_Classes { get; set; }

        public Subject()
        {
            Grades = new HashSet<Grade>();
            Subject_Classes = new HashSet<Subject_Class>();
        }
    }
}
