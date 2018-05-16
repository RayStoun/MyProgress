using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class ListExeption : Exception
    {
        public ListExeption(string message) : base(message)
        {
        }
    }
    public class ListNumber : ISeries
    {
        private double[] series;
        private int currentIndex;

        public ListNumber(double[] series)
        {
            this.series = series;
            currentIndex = 0;
        }

        public double GetCurrent()
        {
            return series[currentIndex];
        }

        public bool MoveNext()
        {
            currentIndex = currentIndex < series.Length - 1 ? currentIndex + 1 : 0;
            return true;
        }

        public void Reset()
        {
            currentIndex = 0;
        }
         public double this[int index]
         {
             get {
                if (index >= 0 && index < series.Length)
                {
                    return series[index];
                }
                else
                {
                    throw new Exception();
                }
            }
         }


    }
}
