using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class Instructor_DTO
    {

        public int InstructorId { get; set; }
        public string InstructorName { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }

    }
}
