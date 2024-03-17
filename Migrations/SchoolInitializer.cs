using lab4_solid.DAL;
using lab4_solid.Entities;
using System.Data.Entity;

namespace lab4_solid.Migrations
{
    internal class SchoolInitializer : DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student { FirstName="Carson", LastName="Alexander", BirthDate=DateTime.Parse("1998-05-15"), Email="carson@example.com", RegistrationDate=DateTime.Parse("2020-09-01")},
                new Student { FirstName="Meredith", LastName="Alonso", BirthDate=DateTime.Parse("1997-08-20"), Email="meredith@example.com", RegistrationDate=DateTime.Parse("2019-09-01")},
                new Student { FirstName="Arturo", LastName="Anand", BirthDate=DateTime.Parse("1999-03-10"), Email="arturo@example.com", RegistrationDate=DateTime.Parse("2021-01-15")},
                // Add more students as needed
            };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var teachers = new List<Teacher>
            {
                new Teacher { FirstName="John", LastName="Doe", BirthDate=DateTime.Parse("1985-10-25"), Email="john@example.com", RegistrationDate=DateTime.Parse("2010-09-01")},
                new Teacher { FirstName="Jane", LastName="Smith", BirthDate=DateTime.Parse("1978-07-12"), Email="jane@example.com", RegistrationDate=DateTime.Parse("2012-03-15")}
                // Add more teachers as needed
            };
            teachers.ForEach(t => context.Teachers.Add(t));
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course{Name="Chemistry", TeacherID=1, Semester=1, Year=2023},
                new Course{Name="Microeconomics", TeacherID=2, Semester=1, Year=2023},
                new Course{Name="Macroeconomics", TeacherID=2, Semester=2, Year=2023},
                // Add more courses as needed
            };
            courses.ForEach(c => context.Courses.Add(c));
            context.SaveChanges();

            var grades = new List<Grade>
            {
                new Grade{GradeNotation=85, StudentID=1, CourseID=1},
                new Grade{GradeNotation=70, StudentID=1, CourseID=2},
                new Grade{GradeNotation=80, StudentID=1, CourseID=3},
                // Add more grades as needed
            };
            grades.ForEach(g => context.Grades.Add(g));
            context.SaveChanges();
        }
    }
}