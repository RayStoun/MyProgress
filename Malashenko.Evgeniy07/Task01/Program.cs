using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new DynamicArray<int>();//создаём пустую коллекцию
            Console.WriteLine("Добавляем массив чисел:");
            Print(arr);//Создаём пустую коллекцию
             arr.AddRange(new int[] { 9, 8, 7, 6, 5, 4, 3 });
            Print<int>(arr);
            Console.WriteLine("используем метод Add");
            int item = 10000;
            arr.Add(item);
            Print(arr);
            Console.WriteLine("\n Использвуем метод Insert");
            item = 2000;
            arr.Insert(6, item);
            Print(arr);
            item = 900;
            arr.Insert(0, item);
            Print(arr);
            item = 5555;
            arr.Insert(arr.Length, item);
            Print(arr);
            Console.WriteLine("\nИспользую метод Remove");
            arr.Remove(0);
            Print(arr);
            Console.WriteLine(" 6 element");
            arr.Remove(6);
            Print(arr);
            Console.WriteLine(" last element");
            arr.Remove(arr.Length-1);
            Print(arr);
            Console.ReadKey();
        }

        /// <summary>
        /// Выводит на консоль
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr">my array</param>
        static void Print<T>(DynamicArray<T> arr) where T : new()
        {
            Console.WriteLine($"Capacity = {arr.Capacity}, Length = {arr.Length}:");
            for (int i = 0; i < arr.Capacity; i++)
            {
                Console.Write($"{arr[i]}  ");
            }
            Console.WriteLine("\n");
        }
    }
}
