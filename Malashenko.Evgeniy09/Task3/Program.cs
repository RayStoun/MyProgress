using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadClass threadClass = new ThreadClass();
            threadClass.CreateNewThread(12,"Thread1");

            ThreadClass threadClass2 = new ThreadClass();
            threadClass2.CreateNewThread(11,"OlOLOL");
            Console.ReadKey();
            
            
        }
        

    }
}
