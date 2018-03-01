using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size triangle");
            int size = Int32.Parse(Console.ReadLine());
            if (size<=0)
            {
                Console.WriteLine("Error! Size must be more zero! ");
            }
            else
            {
                DrawsIndentation(size);
            }
        }

        static private void DrawsIndentation(int size)
        {
            string resulstring = "";
            for (int i = 1; i <size ; i++)
            {
                resulstring = "";
                int numberspace = size -i;
                resulstring = resulstring.PadLeft(numberspace,' ');
                resulstring = resulstring + new string('*', (i*2)-1);
                Console.WriteLine(resulstring);
            }
            Console.ReadKey();
        }

    }
}
