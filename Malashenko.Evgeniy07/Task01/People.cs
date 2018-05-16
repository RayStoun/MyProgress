using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class People
    {
        public string Name { get; set; }
        public int Age
        {
            get
            {
                return Age;
            }
            set
            {
                if (value > 0 && value < 101)
                {
                    Age = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}
