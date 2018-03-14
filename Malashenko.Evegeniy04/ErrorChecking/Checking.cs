using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ErrorChecking
{
    public class Checking
    {
        static public string CheckingName(string value)
        {

            while (value == String.Empty || value.Length > 20 || Regex.IsMatch(value, "\\W"))
            {
                Console.WriteLine("Ошибка! Фамилия на должна быть пуста, размер фамилии не должен быть" +
                       "больше 20 символов и включать в себя не текстовые символы");
                value = Console.ReadLine();
            }
            return value;
           
        }
    }
}
