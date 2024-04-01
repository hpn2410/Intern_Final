using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class Instructor
    {
        public Instructor()
        {
            Classes = new HashSet<Class>();
        }

        public int InstructorId { get; set; }
        public string InstructorName { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
    }
}
