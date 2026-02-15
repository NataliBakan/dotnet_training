using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_7_8
{
    class UserActionHistory
    {
        public string ActionName { get; set; }
        public DateTime Time { get; set; }

        public UserActionHistory(string actionName, DateTime time)
        {
            ActionName = actionName;
            Time = time;
        }
    }
}
