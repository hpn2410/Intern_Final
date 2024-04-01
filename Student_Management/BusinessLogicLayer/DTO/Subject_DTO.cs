using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class Subject_DTO
    {

        public int SubjectId { get; set; }
        public string SubjectCode { get; set; } = null!;
        public string SubjectName { get; set; } = null!;

    }
}
