using lab4_solid.Abstractions;
using lab4_solid.DAL;
using lab4_solid.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_solid.Models
{
    internal class StudentModel: IStudent
    {
        private readonly SchoolContext _context;
        private readonly Student _student;

        public StudentModel(SchoolContext context, Student student)
        {
            _context = context;
            _student = student;
        }

        public void RegisterCourse(Course course)
        {
            var studentCourse = new StudentCourse { StudentID = _student.ID, CourseID = course.ID };
            _context.StudentCourses.Add(studentCourse);
            _context.SaveChanges();
        }

        public void UnregisterCourse(Course course)
        {
            var studentCourse = _context.StudentCourses.FirstOrDefault(sc => sc.StudentID == _student.ID && sc.CourseID == course.ID);
            if (studentCourse != null)
            {
                _context.StudentCourses.Remove(studentCourse);
                _context.SaveChanges();
            }
        }

        public Collection<Course> Courses()
        {
            return new Collection<Course>(_student.StudentCourses.Select(sc => sc.Course).ToList());
        }

        public Collection<Grade> GetAllGrades()
        {
            return new Collection<Grade>(_context.Grades.Where(g => g.StudentID == _student.ID).ToList());
        }
    }
}
