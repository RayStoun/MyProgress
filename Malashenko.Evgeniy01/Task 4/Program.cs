using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle creation program");
            Console.WriteLine("Enter number ");
            int size =Int32.Parse(Console.ReadLine());
            int numberindentation = size-1;
            string drawsStars = "";
            string numberStars = "";
            while (size <= 0)
            {
                Console.WriteLine("Size must be more zero!\r Pleae try again");
                 size = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i <size; i++)
            {  
                numberStars = new string('*',(i*2)>0?(i*2)-1:(i));
                drawsStars = DrawsIndentation(numberindentation)+numberStars;
                numberindentation--;
                
                Console.WriteLine(drawsStars);
            }
            Console.ReadKey();
        }
        static private string DrawsIndentation(int sizeIndentation)
        {
            string indentation = "";
            indentation = indentation.PadLeft(sizeIndentation);
            return indentation;
           
        }

    }
}
