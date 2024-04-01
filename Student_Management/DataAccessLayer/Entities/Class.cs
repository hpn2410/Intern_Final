using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    internal class Class
    {
        public int Class_Id { get; set; }
        public string Class_Code { get; set; }

        public ICollection<Subject_Class> Subject_Classes { get; set; }
        public ICollection<Instructor_Class> Instructor_Classes { get; set; }

        public Class()
        {
            Subject_Classes = new HashSet<Subject_Class>();
            Instructor_Classes = new HashSet<Instructor_Class>();
        }
    }
}
