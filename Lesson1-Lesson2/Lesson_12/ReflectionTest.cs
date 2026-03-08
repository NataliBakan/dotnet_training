using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Lesson_12
{
    class ReflectionTest
    {
        public static void PrintProperties(object obj) 
        {
            var t = obj.GetType();
            Console.WriteLine(t.Name);

            foreach (var prop in t.GetProperties())
            {
                Console.WriteLine($"{prop.Name}: {prop.GetValue(obj)}");
            }
        }
    }
}
