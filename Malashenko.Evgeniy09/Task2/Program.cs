using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person("Harry");
            var p2 = new Person("Ronanld");
            var p3 = new Person("Germiona");
            p3.Came += p1.Greet;
            p3.Came += p2.Greet;
            p3.OnCame();
        }
    }
}
