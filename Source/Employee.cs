using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc7.Models
{
    [Table("tblEmployee")]
    public class Employee
    {
        public int Employeeid { get; set; }
        public String Name { get; set; }
        public String Gender { get; set; }
        public String City { get; set; }

    }
}
