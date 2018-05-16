using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CompareDate
    {
        static public int GetDifferenceDate(DateTime differenceTime)
        {
            DateTime dateNow = DateTime.Now;
            int age = dateNow.Year - differenceTime.Year;
            if (dateNow.Month < differenceTime.Month ||
            (dateNow.Month == differenceTime.Month && dateNow.Day < differenceTime.Day)) age--;
            return age;
        }
    }
}
