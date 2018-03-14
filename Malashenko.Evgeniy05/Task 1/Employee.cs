using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task1
{
    class Employee : User
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
                if (value != String.Empty && value.Length <= 18 || Regex.IsMatch(value, "(^\\w+\\s?-?\\w?\\d?)"))
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
                return WorkExperience;
            }
            private set
            {
                DateTime dateNow = DateTime.Now;
                int timeWork = dateNow.Month - startWork.Month;
                WorkExperience = timeWork / 12;

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
                if (value > DateTime.Now ||value<BirthDate)
                {
                    throw new UserExeption("Inavlid date");
                }
                else
                {
                    startWork = value;
                }
            }
        }
    }

    
}
