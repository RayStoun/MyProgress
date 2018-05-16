using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface ICanvas
    {
        void DrawRound(int x, int y, int radius);
        void DrawLine(int x, int y);
        void DrawRectangle(int sideA, int sideB);

    }
}
