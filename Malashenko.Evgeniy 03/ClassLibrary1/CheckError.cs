using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class CheckError
    {
        private static string CheckNull(this string str, string line)
        {
            while (String.IsNullOrEmpty(line))
            {
                Console.WriteLine("Line must be null, please try again");
                line = Console.ReadLine();
            }
            return line;
        }
        private static string CheckStringAtNumber(this string str,string line)
        {

            for (int i = 0; i < line.Length; i++)
            {
                while (Char.IsDigit(line[i]))
                {
                    Console.WriteLine("Error! Numbers are not allowed in this program!\nPlease, try again");
                    line = Console.ReadLine();
                    i = 0;/*когда код проходит заного, итый элемент имеет старую величину выходит ошибка, здесь мы обновляем его
                    значение*/
                }
            }
            return line;
        }
        public static string FullCheckErrorString(this string str, string line)
        {
            line = line.CheckNull(line);
            line = line.CheckStringAtNumber(line);
            return line;
        }
    }
}
