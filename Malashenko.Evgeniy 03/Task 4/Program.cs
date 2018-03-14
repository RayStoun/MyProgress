using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;


namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Comparing Speed String and Stringbuilder");
            string str = "";
            int N = 100;

            for (int i = 1; i <2000; i++)
            {
                StringBuilder sb = new StringBuilder();
                N *=2;
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (int j = 0; j <N; j++)
                {
                    str += "*";
                }
                stopwatch.Stop();
                TimeSpan timeSpan1 = stopwatch.Elapsed;
                stopwatch.Restart();
                for (int h = 0; h < N; h++)
                {
                    
                    sb.Append("*");
                }
                stopwatch.Stop();
                TimeSpan timeSpan2 = stopwatch.Elapsed;

                Console.WriteLine($"Время работы String         N={N} total= {timeSpan1.TotalMilliseconds}");
                Console.WriteLine($"Время работы StringBuilder N={N}  total ={timeSpan2.TotalMilliseconds} \n");
            }
            Console.ReadKey();
        }
    }
}
