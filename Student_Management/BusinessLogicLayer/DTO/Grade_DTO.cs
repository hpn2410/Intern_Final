using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class Grade_DTO
    {
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public decimal? GradeNumber { get; set; }

    }
}
