using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Random random = new Random();
            int[,] array2D = new int[10, 10];
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    array2D[i, j] = random.Next(-100, 100);
                    if ((i+j)%2==0)
                    {
                        sum += array2D[i, j];
                    }
                }
            }
            Console.WriteLine($"Summ all element stay in  even positions {sum}");
            Console.ReadKey();
        }
    }
}
