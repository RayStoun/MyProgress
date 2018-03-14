using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayCultureInfo(new CultureInfo("ru-Ru"));
            DisplayCultureInfo(new CultureInfo("en-Us"));
            DisplayCultureInfo(new CultureInfo(""));
            Console.ReadKey();
        }
        static void DisplayCultureInfo(CultureInfo nameCulture)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine($"culture =    {nameCulture.DisplayName}");
            Console.WriteLine($"Splitter =   \'{nameCulture.NumberFormat.CurrencyDecimalSeparator}\'");
            Console.WriteLine($"Separator of thousands  = \'{nameCulture.NumberFormat.CurrencyGroupSeparator}\'");
            Console.WriteLine($"culture date={dt.ToString( nameCulture.DateTimeFormat)}\n\n\n")  ;
        }

       
    }
}
