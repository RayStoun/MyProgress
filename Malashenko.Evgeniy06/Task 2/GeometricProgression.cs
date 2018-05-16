using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class GeometricProgression : ISeries
    {
        public GeometricProgression(int start, int step)
        {
            this.start = start;
            this.step = step;
        }
        private int start;
        private int step;
        private int currentIndex;

        public double GetCurrent()
        {
            return start * (Math.Pow(step, currentIndex - 1));
        }

        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = 1;
        }
    }
}
