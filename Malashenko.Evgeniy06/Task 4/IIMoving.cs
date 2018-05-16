using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    interface IIMoving
    {
        void Moving(Entiti entities);
        double Speed { get; set; }
    }
}
