using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    internal class Instructor_Class
    {
        public int Class_Id { get; set; }
        public Class Class { get; set; }

        public int Instructor_Id { get; set; }
        public Instructor Instructor { get; set; }
        public Instructor_Class() { }
    }
}
