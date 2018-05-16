using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
       
        static void Main(string[] args)
        {
            EditFile editFile = new EditFile();
            string name = "disposable_task_file.txt";
            List<int> listInt = editFile.ReadingNumber(name);
            editFile.SqrtInts(ref listInt);
            editFile.WriteInt(name, listInt);

            Console.WriteLine("Файл отредактирован");
            Console.ReadKey();
        }
    }
}
