using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exercise10_1.Models
{
    public partial class Student
    {
        public int IdStudent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string IndexNumber { get; set; }
        public int IdStudies { get; set; }

        [ForeignKey("IdStudies")]
        public Studies Study { get; set; }
    }
}
