using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Program

    {
        static void Main()
        {
            ISeries progression = new ArithmeticalProgression(2, 2);
            Console.WriteLine("Progression:");
            IIndexable indexable = new ArithmeticalProgression(2, 2);
            


            PrintSeries(progression);

            ListNumber list = new ListNumber(new double[] { 5, 8, 6, 3, 1 });
            
            Console.WriteLine("List:");
            Console.WriteLine(list[5]);
            PrintSeries(list);
            Console.ReadKey();
        }
        static void PrintSeries(ISeries series)
        {
            series.Reset();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }
    }
}
