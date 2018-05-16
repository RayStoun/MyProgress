using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task2
{
    public delegate void Message(string name, DateTime date);
    class Person
    {
        public event Message Came;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (String.IsNullOrEmpty(value) || Regex.IsMatch(value,"[\\W]"))
                {
                    throw new ArgumentNullException("Name must be don't null");
                }
                else
                {
                    name = value;
                }
            }
        }
        private string name;

        public Person(string name)
        {
            Name = name;
        }

        public void Greet(string anotherPerson, DateTime dateTime)
        {
            var time = string.Empty;

            if (dateTime.Hour < 12)
            {
                time = "morning";
                Console.WriteLine($"Good {time} {Name} said {anotherPerson}");
            }
            else if (dateTime.Hour < 17 & dateTime.Hour > 12)
            {
                time = "day";
                Console.WriteLine($"Good {time} {Name} said{anotherPerson}");
            }
            else
            {
                time = "evening";
                Console.WriteLine($"Good {time} {Name} {anotherPerson  }");
            }
        }
        public void Goodbye(string anotherPerson)
        {
            {
                Console.WriteLine($"Goodbuy {Name} said {anotherPerson}.");
            }
        }
        public void OnCame()
        {
            if (Came != null)
            {
                Came(Name, DateTime.Now);
            }
        }
    }
}
