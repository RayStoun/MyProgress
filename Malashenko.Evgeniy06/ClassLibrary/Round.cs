using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckError;

namespace ClassLibrary
{

    public class Round : Figure
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Radius;       
        
        public new  string Name = "Round";
        public Round(int x,int y,int radius)
        {
            Radius = radius;
            this.X = x;
            this.Y = y;
        }

        public override void Draw(ICanvas canvas)
        {
            canvas.DrawRound(X,Y,Radius);
        }

    }
}
