using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in program\n");
            Console.WriteLine("please choose mode operation");
            Console.WriteLine("For observation put 1");
            Console.WriteLine("if you wont' to recovering, please put 2");
            ConsoleKeyInfo key;
            key = Console.ReadKey(true);
            if (Char.ToLower(key.KeyChar)=='1')
            {
                Wacth();
            }
            if(Char.ToLower(key.KeyChar)=='2')
            {
                BackUp();
            }

        }
        static void Wacth()
        {
            Watcher myWatcher = new Watcher();
            myWatcher.Run();
            myWatcher.Start();
            myWatcher.Stop();
        }
        static void BackUp()
        {
            Watcher myWatcher = new Watcher();
            Console.WriteLine("Available for recovery");
            myWatcher.PrintBackUps();
            Console.WriteLine("Enter date for rollback");
            string selectBackup = Console.ReadLine();
            myWatcher.Restore(selectBackup);
           
        }

    }
}
