using lab4_solid.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_solid
{
    internal interface IStudent
    {
        //void RegisterCourse(Course course);
        //void UnregisterCourse(Course course);
        Collection<Course> Courses();
        //Grade GetGrade(Course course);
        Collection<Grade> GetAllGrades();
    }
}
