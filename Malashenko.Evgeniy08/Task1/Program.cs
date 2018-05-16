using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> demolist = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            LinkedList<int> vs = new LinkedList<int>();
            LinkedListNode<int> linkedList = vs.AddLast(1);
            for (int i = 0; i < demolist.Count; i++)
            {
                vs.AddLast(demolist[i]);
            }
            Console.WriteLine(RemoveEachSecondItem(demolist).ElementAt(0));
            Console.ReadKey();
        }
        static private ICollection<int> RemoveEachSecondItem(ICollection<int> ts)
        {
            if (ts.Count == 0)
            {
                throw new ArgumentException("Array dont must be null");
            }
            bool secound = false;
            while (ts.Count != 1)
            {
                int[] temp = ts.ToArray();
                foreach (var item in temp)
                {
                    if (ts.Count == 1)
                    {
                        break;
                    }
                    if (secound)
                    {
                        ts.Remove(item);
                    }
                    secound = !secound;

                }
            }
            return ts;
        }
    }
}
