using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    internal class Grade
    {
        public int Student_Id { get; set; }
        public Student Student { get; set; }

        public int Subject_Id { get; set; }
        public Subject Subject { get; set; }

        public decimal Grade_Number { get; set; }

        // Constructor
        public Grade() {}
    }
}
