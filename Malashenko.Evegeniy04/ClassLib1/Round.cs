using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ClassLibrary
{
    class RoundExeption : Exception
    {
        public RoundExeption(string message) : base(message)
        {

        }
    }
    class Round
    {
        private double x;
        private double y;
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                ChekForMoreThanZero(radius, value);
            }
        }
        
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                ChekForMoreThanZero(x, value);
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                ChekForMoreThanZero(y, value);
            }
        }
        public double LongRound
        {

            get
            {
                return radius * 2 * Math.PI;
            }

        }
        public double AreaRound
        {
            get
            {
                return radius * radius * Math.PI;
            }
        }
        public Round(double x, double y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }
        static private void ChekForMoreThanZero(double x,double value)
        {
            if (value > 0)
            {
                x = value;
            }
            else
            {
                throw new RoundExeption("Value must be more 0");
            }
        }
    }
}