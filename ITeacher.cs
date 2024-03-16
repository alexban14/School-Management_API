using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab4_solid.Entities;

namespace lab4_solid
{
    internal interface ITeacher
    {
        Collection<Course> GetTeachingCourses();
        void TeachCourse(Course course);
        void UnteachCourse(Course course);
        void GradeStudent(Student student, Course course, Grade grade);
        Collection<Grade> GetStudentGrades(Student student);
    }
}
