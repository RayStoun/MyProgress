using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Task3
{
    class ThreadClass
    {
        private Thread myThread1;
        public void CreateNewThread(int sleepTime=0, string name="Thread1")
        {
            myThread1 = new Thread( StarterProject);
            myThread1.Name = name;
            myThread1.Start();

            Console.ReadKey();
        }
        
        private void StarterProject()
        {
            MySorting sorting = new MySorting();
            sorting.EndSort += sorting.PrintDone;
            sorting.StartSort(myThread1.Name);
           
        }
    }
}
