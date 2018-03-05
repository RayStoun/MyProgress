using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {

        static Random random = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter a minimum, and maximum value array");
            int min = int.Parse(Console.ReadLine());
            
            int max = int.Parse(Console.ReadLine());
            while (min >= max)
            {

                Console.WriteLine("Error! Number maximum must be more the value minimum\n\r, please, try again");
                max = int.Parse(Console.ReadLine());
            }
            ViewingArray(SortBubble(GetArray(min, max)));
            
        }
        static private int [] GetArray(int min, int max)
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(min, max);
            }
            return array;
        }
       static private int [] SortBubble(int [] array)
       {
            int temp;
            for (int x = 0; x <array.Length; x++)
            {
                for (int y = 0; y <array.Length; y++)
                {
                    if(array[x] > array[y])
                    {
                        temp = array[x];
                        array[x] = array[y];
                        array[y] = temp;
                    }
                }
            }
            return array;
       }
        static private void ViewingArray(int [] array)
        {
            for (int i = 0; i <array.Length; i++)
            {
                Console.WriteLine($"{i+1} element = {array[i]}");
            }
            Console.WriteLine($"\n\n\nMax value array={MaxValueInArray(array)}");
            Console.WriteLine($"\n\nMin value array={MinValueInArray(array)}");
            Console.ReadKey();
        }
        static private int  MaxValueInArray(int [] array)
        {
            int MaxValue = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (MaxValue < array[i])
                {
                    MaxValue = array[i];
                }
            }
            return MaxValue;
        }
        static private int MinValueInArray(int [] array)
        {
            int MinValue = array[0];
            for (int i = 0; i <array.Length; i++)
            {
                if (MinValue > array[i])
                {
                    MinValue = array[i];
                }
            }
            return MinValue;
        }
        

    }
}
