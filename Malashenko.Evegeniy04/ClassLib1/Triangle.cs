using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class TriangleExeption : Exception
    {
        public TriangleExeption(string message) : base(message)
        {

        }
    }
    class Triangle
    {
        private double sideA;
        private double  sideB;
        private double sideC;
        public double SideA
        {
            get
            {
                return sideA;
            }
            set
            {
                CheckingSides(sideA, sideB, sideC, value);
            }
        }
        public double SideB
        {
            get
            {
                return sideB;
            }
            set
            {
                CheckingSides(sideB, sideC, sideA, value);
            }
        }
        public double SideC
        {
            get
            {
                return sideC;
            }
            set
            {
                CheckingSides(sideC, sideA, sideB, value);
                
            }
        }        
        public double Perimeter
        {
            get
            {
                return (sideC + sideB + sideA) / 2;
            }
        }
        public double AreaTriangle
        {
            get
            {
                return Math.Sqrt(Perimeter * (Perimeter - sideA) * (Perimeter * SideB) * (Perimeter * sideC));
            }
        }
        static private void CheckingSides(double checkside, double side1, double side2, double value)
        {
            if (value > side1 + side2 || value <= 0)
            {
                throw new TriangleExeption("the side length must not be greater than the sum of the other two sides");
            }
            else
            {
                checkside = value;
            }

        }
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
    }
}
