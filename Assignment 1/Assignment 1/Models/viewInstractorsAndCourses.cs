using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Models
{
    public class viewInstractorsAndCourses
    {
        [Key]
        public String InstractorName { get; set; }
        [Key]
        public String CourseName { get; set; }
    }
}
