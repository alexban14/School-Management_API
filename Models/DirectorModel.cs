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
    internal class DirectorModel
    {
        private readonly SchoolContext _context;
        private readonly Director _director;

        public DirectorModel(SchoolContext context, Director director)
        {
            _context = context;
            _director = director;
        }

        public Collection<Grade> GetStudentGrades()
        {
            return new Collection<Grade>(_context.Grades.ToList());
        }
    }
}
