using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_7_8
{
    class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public int GetAge() 
        {
            var today = DateTime.Now;
            int age = today.Year - BirthDate.Year;

            return BirthDate.AddYears(age) > today ? age - 1 : age;
        } 
    }
}
