using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_5_6
{
    class MemoryStorage : IStorage
    {
        public void Save(string data)
        {
            Console.WriteLine("Данные сохранены в память");
        }
    }
}
