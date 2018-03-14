using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the string");
            string line = Console.ReadLine();
            line = line.FullCheckErrorString(line);
            Console.WriteLine("Please, enter a duplicate line");
            string deplicateLine = Console.ReadLine();
            deplicateLine = deplicateLine.FullCheckErrorString(deplicateLine);
            Console.WriteLine(DoubleCharacters( SplitIntoUniqueSymbols(deplicateLine),line));
            //Console.WriteLine(DoubleString(line, deplicateLine));
            Console.ReadKey();

        }
       static private List<char> SplitIntoUniqueSymbols(string line )
        {
            List<char> charlist = new List<char>();
            
            for (int i = 0; i<line.Length; i++)
            {
                charlist.Add(line[i]);
                
            }
            var newlist = new List<char>(charlist.Distinct());
           
            return newlist;
        }
        
        static private StringBuilder DoubleString(string line, string duplicateLine)
        {
            StringBuilder stringBuilder = new StringBuilder(duplicateLine.Length *2);
            for (int i = 0; i < line.Length; i++)
            {
                stringBuilder.Append(line[i]);
                if (duplicateLine.IndexOf(line[i]) >= 0)//если элемент не найден индекс -1
                {
                    stringBuilder.Append(line[i]);
                }
            }
            return stringBuilder;
        }
        static private string DoubleCharacters(List<char> duplicateLine, string line)
        {
            string result = "";
            List<char> resultList = new List<char>();
            char[] charLine = line.ToCharArray();
            
            for (int j = 0; j <charLine.Length; j++)
            {
                resultList.Add(charLine[j]);
                if (duplicateLine.IndexOf(charLine[j])>=0)
                {
                    resultList.Add(charLine[j]);
                }
                
            }
            // for (int k = 0; k < resultList.Count; k++)
            //{
            //  result += resultList[k].ToString();
            //}
            //return result;
            result = String.Join(string.Empty,resultList);
            return result; 
        }
        //private static string DoubleSign(string line, string duplicateLine)
        //{
        //    string resultString = "";
        //    List <char> duplicateList=SplitIntoUniqueSymbols(duplicateLine);
        //    char[] charLine = line.ToCharArray();
        //    for (int j = 0; j < charLine.Length; j++)
        //    {
        //        char ch=charLine[j];
        //        resultString += charLine[j];
        //        if (duplicateLine.IndexOf(charLine[j]) >= 0)
        //        {
        //            resultString = resultString.Replace(charLine[j], new string(ch ,2));
        //        }

        //    }
        //    return resultString;
        //}

    }
}
