using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lessons_7_8
{
    class Student
    {
        public Guid Guid { get; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }

        public static List<Student> GetExcellentStudents(List<Student> students)
        {
            return students.FindAll(student => student.Grade >= 4);
        }
    }
}
