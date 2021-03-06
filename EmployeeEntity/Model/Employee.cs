﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeEntity.Model
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; } 
        public string City { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
    }
}
