using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
                if (array[i] > 0)
                {
                    Sum += array[i];
                }
            }
            Console.WriteLine($" Sum positive number = {Sum}");
            Console.ReadKey();

        }
    }
}
