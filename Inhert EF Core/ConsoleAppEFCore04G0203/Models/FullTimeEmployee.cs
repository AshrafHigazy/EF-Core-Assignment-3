﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertEFCore.Models
{
    public class FullTimeEmployee:Employee
    {
        public DateOnly StartDate {  get; set; }

        public decimal Salary { get; set; }
    }
}
