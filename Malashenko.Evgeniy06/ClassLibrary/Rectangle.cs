using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Rectangle : Figure
    {
        public Rectangle(int sideA, int sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }
        public int sideA { get; private set; }
        public int sideB { get; private set; }
        public new  string Name = "Rectangle";
        public override void Draw(ICanvas canvas)
        {
            canvas.DrawRectangle(sideA, sideB);
        }
    }
}
