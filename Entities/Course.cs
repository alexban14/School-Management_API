using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_solid.Entities
{
    internal class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Semester { get; set; }
        public int Year { get; set; }
        public List<string> Requirements { get; set; }
        public int TeacherID { get; set; }
        
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}


