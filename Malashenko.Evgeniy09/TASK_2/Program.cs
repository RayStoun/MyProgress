using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TASK_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("James");
            Person person2 = new Person("Lars");
            Person person3 = new Person("Kirk");
            Person person4 = new Person("Deive");
            Person person5 = new Person("Tom");
            Office office = new Office();
            FunctionCame(person1, office);
            FunctionCame(person2, office);
            FunctionCame(person3, office);
            FunctionCame(person4, office);
            FunctionCame(person5, office);
            FunctionLeave(person1, office);
            FunctionLeave(person2, office);
            FunctionLeave(person3, office);
            FunctionLeave(person4, office);
            FunctionLeave(person5, office);
            Console.ReadKey();

        }
        public static void FunctionCame(Person person, Office office)
        {
            Thread.Sleep(400);
            office.CameInOffice(person);
            Console.WriteLine();
            
        }
        public static void FunctionLeave(Person persone, Office office)
        {
            Thread.Sleep(700);
            office.GoHome(persone);
            Console.WriteLine();

        }
    }
}
