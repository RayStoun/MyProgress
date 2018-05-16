using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_2
{
    class Office
    {
        private GreetMessage greetAll;

        private GoodbyeMessage byeAll;

        public void PersonCame(Person person, DateTime time)
        {
            Console.WriteLine($"Worker {person.Name} came to work");
            if (greetAll != null)
            {
                greetAll(person, time);
            }

            greetAll += person.Greet;
            byeAll += person.Goodbye;
        }

        public void PersonLeave(Person person)
        {
            Console.WriteLine($"Worker {person.Name} leave to work");
            byeAll-= person.Goodbye;
            greetAll -= person.Greet;
            if (byeAll != null)
            {
                byeAll.Invoke(person);
            }
        }

        public void CameInOffice(Person p)
        {
            p.Came += PersonCame;
            p.Leave += PersonLeave;

            //
            p.GoToWork();
        }
       
        public void GoHome(Person p)
        {
            p.GoHome();

            p.Came -= PersonCame;
            p.Leave -= PersonLeave;
        }
    }
}
