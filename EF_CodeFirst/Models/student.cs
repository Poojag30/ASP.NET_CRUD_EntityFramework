using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EF_C1.Models
{
    public class student
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}