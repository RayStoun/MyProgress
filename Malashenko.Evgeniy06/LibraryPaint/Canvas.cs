using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace LibraryPaint
{
    public class Canvas : ICanvas
    {
       

        public void DrawLine(int x, int y)
        {
            Console.WriteLine($"Draw {Line.Name} with the coordinate x={x} and y={y}");
        }

        public void DrawRectangle(int sideA, int sideB)
        {
            Console.WriteLine($"Draw {Rectangle.Name} with the side A ={sideA} with the side B {sideB}");
        }

        public void DrawRound(int x, int y, int radius)
        {
            Console.WriteLine($"Draw {Round.Name} with the coordinate x={x} , y={y} and radius ={radius}  ");
        }
       
    }
}
