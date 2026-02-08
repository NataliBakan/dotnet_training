using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_5_6
{
    class MemoryStorage: IStorage
    {
        public string Save(string data)
        {
            return "Данные сохранены в память";
        }
    }
}
