using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_5_6.Structures
{
    struct DayInfo
    {
        public int Day { get; set; }
        public int Month { get; set; }

        public DayInfo(int day, int month)
        {
            Day = day;
            Month = month;
        }

        public bool IsValid() 
        {
            return Day > 0 && Day < 32 && Month > 0 && Month < 13;
        }
    }
}
