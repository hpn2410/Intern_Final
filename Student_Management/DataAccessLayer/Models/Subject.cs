using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Grades = new HashSet<Grade>();
            Classes = new HashSet<Class>();
        }

        public int SubjectId { get; set; }
        public string SubjectCode { get; set; } = null!;
        public string SubjectName { get; set; } = null!;

        public virtual ICollection<Grade> Grades { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
    }
}
