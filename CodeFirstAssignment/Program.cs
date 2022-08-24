using CodeFirstAssignment.DataModel;
using CodeFirstAssignment.Enums;
using System;
using System.Collections.Generic;
namespace CodeFirstAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            using Context myContext = new Context();
            myContext.Students.Add(new Student()
            {
                StudentID = 24,
                StudentFirstName = "Seyi",
                StudentLastName = "Law",
                Age = 24,
                Department = "Computer Science",

                StudentCourse = new List<Course>()
                {
                    new Course()
                    {
                        CourseCode = 101,
                        CourseName = "Computational Maths",
                        CourseLevel = Level.Advanced

                    }
                }
            });
            myContext.SaveChanges();

        }
    }
}
