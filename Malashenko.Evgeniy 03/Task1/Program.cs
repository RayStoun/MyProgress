using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string line = Console.ReadLine();
            line = line.FullCheckErrorString(line);
            double averageNumber=DetermineTheAverageWordLength(line);
            Console.WriteLine($"Average number of letters in the sentence = {averageNumber}");
            Console.ReadKey();
        }
        static double DetermineTheAverageWordLength(string line )
        {
            double sum = 0;
            string[] words = line.Split(new char[] { ' ', '!', '?', ':', ',', '.','\\',';','-','\"','\'' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                sum += words[i].Length;
            }
            double result = sum / words.Length;
            return result;
        }

    }
}
