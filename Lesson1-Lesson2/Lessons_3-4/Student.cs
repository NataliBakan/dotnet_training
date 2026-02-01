using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_3_4
{
    class Student
    {
        public string Name { get; set; }
        public int Group { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int group, double gpa)
        {
            Name = name;
            Group = group;
            Gpa = gpa;
        }

        public bool IsExcellent()
        {
            return Gpa >= 4.5;
        }
    }
}
