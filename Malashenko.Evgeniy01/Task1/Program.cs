using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
       
           
        static void Main(string[] args)
        {
            double sideA = 0;
            double sideB = 0;
            Console.WriteLine("Enter side A");
             sideA = WritesAndReadsNumber(sideA);
            Console.WriteLine("Enter side B");
            sideB= WritesAndReadsNumber(sideB);
            double area = sideB * sideA;
            Console.WriteLine($"\rArea = {area}");
            Console.ReadKey();

        }
       static private double WritesAndReadsNumber(double number)
        {

            number = Double.Parse(Console.ReadLine());
            while (number <= 0)
            {
                Console.WriteLine("Number The input number must be greater than 0.\rPlease try again");
                number = Double.Parse(Console.ReadLine());
            }
            return number;
        }
    }
}
