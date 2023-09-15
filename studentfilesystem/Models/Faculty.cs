﻿using System;
using System.Collections.Generic;

namespace studentfilesystem.Models
{
    public partial class Faculty
    {
        public Faculty()
        {
            Department = new HashSet<Department>();
        }

        public string FacultyId { get; set; }
        public string CollegeId { get; set; }
        public string FacultyName { get; set; }

        public virtual College College { get; set; }
        public virtual ICollection<Department> Department { get; set; }
    }
}
