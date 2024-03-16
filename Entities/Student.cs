using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_solid.Entities
{
    internal class Student : Person
    {
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
    }
}
