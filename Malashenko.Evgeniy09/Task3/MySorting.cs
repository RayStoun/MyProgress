using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task3
{
    public delegate void SortDone(string st);
    class MySorting
    {
        public event SortDone EndSort;
        private delegate bool SortDelegate(string str1, string str2);
        string[] MySort(string[] mass, SortDelegate sortDelegate)
        {
            string temp;
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass.Length; j++)
                {
                    if (!sortDelegate(mass[i], mass[j]))
                    {
                        temp = mass[i];
                        mass[i] = mass[j];
                        mass[j] = temp;
                    }
                }
            }
            return mass;
        }

        private bool AlphabetSort(string str1, string str2)
        {
            if (str1.Length == str2.Length)
            {
                return str1.CompareTo(str2) > 0;
            }
            return str1.Length < str2.Length;
        }

        private string[] CreateMassive()
        {
            Console.WriteLine("Create massive\n");
            string[] wordsLength = new string[5]
            {"yyyyyy","bbbb","ccwww","wwwww","aaaa"
            };
            
            return wordsLength;
        }
        private void PrintMassive( string[] array )
        {
            Console.WriteLine();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        public void StartSort(string namesort)
        {
            SortDelegate sortDelegate = AlphabetSort;
            var massive=CreateMassive();
            Console.WriteLine("Start sorting");
            PrintMassive(MySort(massive, sortDelegate));
            SortFinish(namesort);
        }
         public void SortFinish(string str)
        {
            if (EndSort != null)
            {
                EndSort(str);
            }
        }
        public void PrintDone(string str)
        {
            Console.WriteLine(str+" complete work");
        }

        
    }
}
