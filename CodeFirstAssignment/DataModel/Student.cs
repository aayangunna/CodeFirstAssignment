using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAssignment.DataModel
{
    internal class Student
    {
        public int StudentID { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public List<Course> StudentCourse { get; set; }
    }
}
