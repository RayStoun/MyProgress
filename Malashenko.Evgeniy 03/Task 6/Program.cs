using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number");
            string input = Console.ReadLine();
                if (Regex.IsMatch(input, "\\-?\\d{1,}\\.?\\,?[eEpPmM]{0,3}-?"))
                {
                    if (Regex.IsMatch(input, "-?[\\d]{1,}\\,?\\.?[\\d]+[eEpPmM]{1,}\\-?[\\d]?"))
                    {
                        Console.WriteLine("Number in scientific notation");
                    }
                    else
                    {
                        Console.WriteLine("Number is usal notation");
                    }
                }
            else
            {               
                Console.WriteLine("It's not number");
            }
            Console.ReadKey();
        }
    }
}
