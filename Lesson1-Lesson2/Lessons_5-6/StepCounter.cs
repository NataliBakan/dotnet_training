using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_5_6
{
    class StepCounter
    {
        private int steps;

        public void AddSteps(int count)
        {
            if (count > 0)
            {
                steps += count;
            }
        }

        public void Reset()
        {
            steps = 0;
        }

        public int GetSteps()
        {
            return steps;
        }
    }
}
