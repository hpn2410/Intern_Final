using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class Grade
    {
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public decimal? GradeNumber { get; set; }

        public virtual Student Student { get; set; } = null!;
        public virtual Subject Subject { get; set; } = null!;
    }
}
