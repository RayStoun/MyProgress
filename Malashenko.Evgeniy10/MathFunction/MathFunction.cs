using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunction
{
    public class MathFunction
    {
        static public double VosvedenieVStepen(double x, double step)
        {
            return Math.Pow(x, step);
        }
        static public double FindFactorial(double x, double step)
        {
            if (step <= 1)
            {
                return step;
            }
            else
            {
                return step * x * (step - 1);
            }
            
        }
    }
}
