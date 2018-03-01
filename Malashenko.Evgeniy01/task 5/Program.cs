using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size triangle");
            int size = Int32.Parse(Console.ReadLine());
            if (size <= 0)
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
            for (int i = 1; i < size+1; i++)
            {
                for (int j = 1; j < i+1; j++)
                {
                    resulstring = "";
                    int numberspace = size - j;
                    resulstring = resulstring.PadLeft(numberspace, ' ');
                    resulstring = resulstring + new string('*', (j * 2) - 1);
                    Console.WriteLine(resulstring);
                }
            }
            Console.ReadKey();
        }
    }
}
