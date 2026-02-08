using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_5_6
{
    class User
    {
        public static int TotalUsers { get; private set; } = 0;

        public User()
        {
            TotalUsers += 1;
        }
    }
}
