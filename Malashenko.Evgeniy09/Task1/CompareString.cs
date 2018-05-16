using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class CompareString : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x.Length > y.Length)
                return 1;
            else if (y.Length > x.Length)
                return -1;
            else
            {
                return x.CompareTo(y);
            }
                
           
        }
    }
}
