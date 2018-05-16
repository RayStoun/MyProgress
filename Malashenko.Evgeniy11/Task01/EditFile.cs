using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task01
{
    class EditFile
    {
        private string CurrentPath(string name)
        {
            return Path.Combine(Environment.CurrentDirectory, name);
        }
       
        public List<int> ReadingNumber(string name)
        {
            string path = CurrentPath(name);
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("File not Found");
            }
            List<int> listNumber = new List<int>();
            string[] strNumber = File.ReadAllLines(path);

            for (int i = 0; i < strNumber.Length; i++)
            {
                int number = int.Parse(strNumber[i]);
                listNumber.Add(number);
            }
            return listNumber;
        }
        public void SqrtInts(ref List<int> listInt)
        {
            listInt = listInt.Select(i => i * i).ToList();
        }
        public void WriteInt(string name, List<int> listInt)
        {
            string path = CurrentPath(name);
            if (!File.Exists(path))
            {
                throw new FileNotFoundException();
            }
            using (StreamWriter sr = new StreamWriter(path))
            {
                foreach (var i in listInt)
                {
                    sr.WriteLine(i);
                }
            }
        }
    }
}
