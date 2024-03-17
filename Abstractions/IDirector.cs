using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab4_solid.Entities;

namespace lab4_solid.Abstractions
{
    internal interface IDirector
    {
        Collection<Grade> GetStudentGrades();
    }
}
