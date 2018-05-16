using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckError
{
    public class RoundError : Exception
    {
        public RoundError(string message) : base(message)
        {
        }
    }
}
