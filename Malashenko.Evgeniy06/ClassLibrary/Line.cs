using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Line : Figure
    {
        public int x { get;private set; }
        public int y { get;private set; }
        public  new  string  Name = "Line";
        public Line(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }

        public override void Draw(ICanvas canvas)
        {
            canvas.DrawLine(x,y);
        }

    }
}
