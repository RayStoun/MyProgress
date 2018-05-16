using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Text.RegularExpressions;

namespace Task2
{

    class Employee : User,IEquatable<Employee>
    {
        public Employee(string name, string secoundName, DateTime bithdate, string post, DateTime startWork)
            : base(name, secoundName, bithdate)
        {
            Post = post;
            StartWork = startWork;
        }

        private string post;
        public string Post
        {
            get
            {
                return post;
            }
            set
            {
                if (String.IsNullOrEmpty(value) && value.Length <= 18 || Regex.IsMatch(value, "(^\\w+\\s?-?\\w?\\d?)"))
                {
                    post = value;
                }
                else
                {
                    throw new UserExeption("Invalid post name");
                }
            }
        }
        public int WorkExperience
        {
            get
            {
                return CompareDate.GetDifferenceDate(startWork);
            }
        }
        private DateTime startWork;
        public DateTime StartWork
        {
            get
            {
                return startWork;
            }
            set
            {
                if (value > DateTime.Now || value < BirthDate)
                {
                    throw new UserExeption("Inavlid date");
                }
                else
                {
                    startWork = value;
                }
            }
        }

        public bool Equals(Employee other)
        {
            return base.Equals(other)
                && startWork == other.startWork
                && WorkExperience == other.WorkExperience
                && post == other.post;
        }       
    }

}
