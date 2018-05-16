using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (var k = 1; k < 1000000000; k += 1000)
            {
                Console.WriteLine("K = " + k);
                list.Clear();
                for (int i = k; i < k + 1000; i++)
                {
                    for (int j = k; j < k+ 1000; j++)
                    {
                        list.Add(new TwoDPointWithHash(i, j).GetHashCode());
                    }
                }

                var Hash = list.Distinct().ToArray();
                Console.WriteLine("Количество исключетельных точек :" + Hash.Length.ToString() + "\nРазмер всего массива :" + list.Count.ToString() + "\nРазница :" + (list.Count - Hash.Length).ToString());
                Console.WriteLine();
            }
            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
