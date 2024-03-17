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
    internal class TeacherModel
    {
        private readonly SchoolContext _context;
        private readonly Teacher _teacher;

        public TeacherModel(SchoolContext context, Teacher teacher)
        {
            _context = context;
            _teacher = teacher;
        }

        public Collection<Course> GetTeachingCourses()
        {
            return new Collection<Course>(_teacher.Courses.ToList());
        }

        public void TeachCourse(Course course)
        {
            _teacher.Courses.Add(course);
            _context.SaveChanges();
        }

        public void UnteachCourse(Course course)
        {
            _teacher.Courses.Remove(course);
            _context.SaveChanges();
        }

        public void GradeStudent(Student student, Course course, Grade grade)
        {
            // Find the student's enrollment in the course
            var enrollment = _context.StudentCourses.FirstOrDefault(sc => sc.StudentID == student.ID && sc.CourseID == course.ID);
            if (enrollment != null)
            {
                // Create a new grade record
                var newGrade = new Grade { GradeNotation = grade.GradeNotation, StudentID = student.ID, CourseID = course.ID };
                _context.Grades.Add(newGrade);
                _context.SaveChanges();
            }
        }

        public Collection<Grade> GetStudentGrades(Student student)
        {
            return new Collection<Grade>(_context.Grades.Where(g => g.StudentID == student.ID).ToList());
        }
    }
}
