using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "<b>Это</b> текст <i>с</i> <font color=”red”>HTML</font> кодами ";
            string result = Regex.Replace(str, "<[^>]+>", "_");
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
