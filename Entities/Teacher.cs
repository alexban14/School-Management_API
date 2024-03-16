using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_solid.Entities
{
    internal class Teacher : Person
    {
        public virtual ICollection<Course> Courses { get; set; }
    }
}
