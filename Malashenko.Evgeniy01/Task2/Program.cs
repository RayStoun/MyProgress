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
            Console.WriteLine("Enter number *");
            int numberStars = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < numberStars; i++)
            {
                int j = 1;
                string chislo = new string('*',j+i);
              
                Console.WriteLine(chislo);
            }
            Console.ReadKey();

        }
    }
}
