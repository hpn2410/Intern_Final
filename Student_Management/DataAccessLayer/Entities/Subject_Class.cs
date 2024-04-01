using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    internal class Subject_Class
    {
        public int Class_Id { get; set; }
        public Class Class { get; set; }

        public int Subject_Id { get; set; }
        public Subject Subject { get; set; }
        public Subject_Class() { }
    }
}
