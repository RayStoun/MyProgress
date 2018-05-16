using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public delegate bool SortDelegate(string str1, string str2);
        static void Main(string[] args)
        {

            string[] wordsLength = new string[9];
            for (int i = 0; i < wordsLength.Length; i++)
            {
                wordsLength[i] = Console.ReadLine();
            }
            MySort(wordsLength, AlphabetSort);
            foreach (var item in wordsLength)
            {
                Console.WriteLine(item);
            }
        }
        static string[] MySort(string [] mass, SortDelegate sortDelegate )
        {
            string temp;
            for (int i = 0; i <mass.Length; i++)
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
        static  bool AlphabetSort(string str1, string str2)
        {
            if (str1.Length == str2.Length)
            {
                return str1.CompareTo(str2) > 0;
            }
            return str1.Length < str2.Length;
        }
        
    }
}
