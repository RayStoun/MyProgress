using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task1
{
    class Ring : Round
    {

        public Ring(double x, double y, double radius, double outerRadius) : base(x, y, radius)
        {
            OuterRadius = outerRadius;
        }
        private double outerRadius;
        public double OuterRadius
        {
            get
            {
                return outerRadius;
            }
            set
            {
                if(value > Radius)
                {
                    outerRadius = value;
                }
            }
        }
        public double OutSideArea
        {
            get
            {
                return outerRadius* outerRadius*Math.PI;
            }
        }
        private double AreaRing
        {
            get
            {
                return OutSideArea - AreaRound;
            }
        }
       public double  LongRound
        {
            get
            {
                return base.LongRound + OuterRadius * 2 * Math.PI;
            }
        }



    }
}
