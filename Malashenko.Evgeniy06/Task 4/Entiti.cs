using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    abstract class Entiti
    {
        public double X
        {
            get
            {
                return X;
            }
            set
            {
                if (value > MaxHeight)
                {
                    value = MaxHeight;
                    X = value;
                }
                else
                {
                    X = value;
                }
            }
        }
        public double Y
        {
            get
            {
                return Y;
            }
            set
            {
                if (value >= MaxWidth)
                {
                    value = MaxWidth;
                    Y = value;
                }
                else
                {
                    Y = value;
                }
            }
        }
        public const int MaxHeight = 1000;
        public const int MaxWidth = 2000;
        public bool IAmOnTheMap(Entiti entities)
        {
            if (entities.X > 0 && entities.Y > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string Name { get; set; }
        protected Entiti(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
