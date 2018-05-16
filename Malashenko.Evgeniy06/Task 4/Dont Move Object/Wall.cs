using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Wall:Entiti
    {
        public double X1
        {
            get { return X1; }
            set
            {
                if (value > Entiti.MaxHeight)
                {
                    value = Entiti.MaxHeight;
                    X1 = value;

                }
                else
                {
                    X1 = value;
                }
            }
        }
        public double Y1
        {
            get
            {
                return Y1;
            }
            set
            {
                if (value > Entiti.MaxHeight)
                {
                    value = Entiti.MaxHeight;
                    Y1 = value;

                }
                else
                {
                    Y1 = value;
                }
            }
        }
        protected Wall(double x, double y, double x1, double y2) : base(x, y)
        {
            X1 = x1;
            Y1 = Y1;
        }
    }
}
