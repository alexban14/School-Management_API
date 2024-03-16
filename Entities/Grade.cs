using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_solid.Entities
{
    internal class Grade
    {
        public int ID { get; set; }
        public int GradeNotation { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
