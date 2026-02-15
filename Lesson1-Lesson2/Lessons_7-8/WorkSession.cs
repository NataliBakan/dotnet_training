using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_7_8
{
    class WorkSession
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public WorkSession(DateTime startTime, DateTime endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        public TimeSpan GetDuration()
        {
            return EndTime - StartTime;
        }

        public string GetFormattedDuration()
        {
            var duration = this.GetDuration();

            return $"{(int)duration.TotalHours} часа и {duration.Minutes} минут";
        }
    }
}
