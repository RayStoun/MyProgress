using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAndRewards.Shared
{
    public class UserExeption : Exception
    {
        public UserExeption(string message) : base(message)
        {

        }
    }
    public class User
    {
        public int UserId { get; set;}
        public string FirstName;
        public string LastName;

        public User()
        {
           
        }

        public DateTime BirthDate { get; set; }
        
        static public int GetDifferenceDate(DateTime differenceTime)
        {
            DateTime dateNow = DateTime.Now;
            int age = dateNow.Year - differenceTime.Year;
            if (dateNow.Month < differenceTime.Month ||
            (dateNow.Month == differenceTime.Month && dateNow.Day < differenceTime.Day)) age--;
            return age;
        }
        public int Age
        {
            get
            {
                return GetDifferenceDate(BirthDate);
            }
        }
        public List<Reward> Rewards { get; set; }

    }
}
