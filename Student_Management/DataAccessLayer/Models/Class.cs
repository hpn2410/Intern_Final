using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class Class
    {
        public Class()
        {
            Instructors = new HashSet<Instructor>();
            Subjects = new HashSet<Subject>();
        }

        public int ClassId { get; set; }
        public string ClassCode { get; set; } = null!;

        public virtual ICollection<Instructor> Instructors { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
