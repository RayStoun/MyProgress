
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        { DateTime date = new DateTime(1995, 12, 13);
            Employee employee1 = new Employee("Sergey","Tabachinkov",new DateTime(1995,12,13),"Slesar", new DateTime(2018,03,03));
            Employee employee2 = new Employee("Sergey", "Tabachinkov", new DateTime(1995, 12, 13), "Slesar", new DateTime(2018, 03, 03));
            Employee employee3 = new Employee("Andrey", "Tabachinkov", new DateTime(1995, 12, 13), "Slesar", new DateTime(2018, 04, 03));
            ComparePrint(employee1,employee2);
            ComparePrint(employee2, employee3);
            employee3 = null;
            ComparePrint(employee2, employee3);
            Console.ReadKey();
        }
        static public void ComparePrint(Employee employee, Employee otherEmployee)
        {
            if (employee.Equals(otherEmployee))
            {
                Console.WriteLine(" Одинаковые сотрудники");

            }
            else
            {
                Console.WriteLine("Сотруднки различаются");
            }
        } 
    }
}
