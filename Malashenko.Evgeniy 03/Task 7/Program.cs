using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = " В 7:55 я встал, позавтракал и к 10:77 пошел на работу dsdad 11:50 24:15.";
            var count = Regex.Matches(str, "([^\\w]{1})(([0-1]?[0-9]{1,2}|[0-2]?[0-3])\\:(([0-5][0-9]{1,2})[^\\w]))").Count;
            Console.WriteLine($"В данной строке время встретилось {count}  ");
            Console.ReadKey();
        }
    }
}
