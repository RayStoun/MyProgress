using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TASK_2
{
    //class PersonEventArgs : EventArgs
    //{
    //    public DateTime Time { get; set; }
    //}
    public delegate void GreetMessage(Person pr, DateTime time);
    public delegate void GoodbyeMessage(Person pers);
   public class Person
   {

        public event GreetMessage Came;
        public event GoodbyeMessage Leave;
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (String.IsNullOrEmpty(value) || Regex.IsMatch(value, "[\\W]"))
                {
                    throw new ArgumentNullException("Name must be don't null");
                }
                else
                {
                    name = value;
                }
            }
        }

        public Person(string name)
        {
            Name = name;
        }
        public void Greet(Person anotherPerson, DateTime dateTime)
        {
            var time = string.Empty;

            if (dateTime.Hour < 12)
            {
                time = "morning";
                Console.WriteLine($"Good {time} {anotherPerson.Name} said {Name}");
            }
            else if (dateTime.Hour < 17 & dateTime.Hour > 12)
            {
                time = "day";
                Console.WriteLine($"Good {time} {anotherPerson.Name} said{Name}");
            }
            else
            {
                time = "evening";
                Console.WriteLine($"Good {time} {anotherPerson.Name} said {Name}");
            }
        }
        public void Goodbye(Person anotherPerson)
        {
            Console.WriteLine($"Goodbuy {anotherPerson.Name} said {Name}.");
        }
        public void GoToWork()
        {
            if (Came != null)
            {
                //var args = new PersonEventArgs();
                //args.Time = DateTime.Now;
                //Came(this, args);
                Came(this, DateTime.Now);
            }
        }
        public void GoHome()
        {
            if (Leave != null)
            {
                Leave(this);
            }
        }
        
    }
}
