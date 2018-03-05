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
            int[,,] array3D = new int[5,5,5];
            Random random = new Random();
            for (int i = 0; i < array3D.GetLength(0); i++)
            {
                for (int j = 0; j < array3D.GetLength(1); j++)
                {
                    for (int k = 0; k < array3D.GetLength(2); k++)
                    {
                        array3D[i, j, k] = random.Next(-100, 150);
                        if (array3D[i, j, k] > 0)
                        {
                            array3D[i, j, k] = 0;
                            Console.WriteLine($"positive number = {array3D[i, j, k]}");
                        }
                        else
                        {
                            Console.WriteLine($"Negative number ={array3D[i, j, k]}");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
