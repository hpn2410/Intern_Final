using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Instructor
    {
        public int Instructor_Id { get; set; }
        public string Instructor_Name { get; set; }
        public DateTime? Date_Of_Birth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public ICollection<Instructor_Class> Instructor_Classes { get; set; }

        public Instructor()
        {
            Instructor_Classes = new HashSet<Instructor_Class>();
        }
    }
}
