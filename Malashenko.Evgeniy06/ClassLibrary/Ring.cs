using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckError;

namespace ClassLibrary
{
    public class Ring : Round
    {
        public Ring (int x, int y, int radius ,int radius2) : base(x, y,radius)
        {
            if (radius2<radius)
            {
               radius2 += radius + 1;
            }
            Radius2=radius2;
        }
        public new  string Name = "Ring";

        public int Radius2;
        
        public override void Draw(ICanvas canvas)
        {
            canvas.DrawRound(X, Y, Radius);
            canvas.DrawRound(X, Y, Radius2);
           
            
        }
    }
}
