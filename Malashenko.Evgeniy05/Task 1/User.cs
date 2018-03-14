using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Task1
{
    public class UserExeption : Exception
    {
        public UserExeption(string message) : base(message)
        {

        }
    }
    class User
    {
        public User(string name, string secoundName, DateTime bithdate)
        {
            this.Name = name;
            this.SecoundName = secoundName;
            this.BirthDate = bithdate;
        }
        public User(string name, string secoundName, DateTime bithdate, string patronymic) : this(name, secoundName, bithdate)
        {
            Patronymic = patronymic;
        }
        private string name;
        private string secoundName;
        private string patronymic;
        private int age;
        private DateTime dateBirthDay;


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                ChekingName(value, name);
            }
        }
        public string SecoundName
        {
            get
            {
                return secoundName;
            }
            set
            {
                ChekingName(value, secoundName);

            }
        }
        public string Patronymic
        {
            get
            {
                return patronymic;
            }
            set
            {
                ChekingName(value, patronymic);
            }
        }
        public DateTime BirthDate
        {
            get
            {
                return dateBirthDay;
            }
            set
            {
                DateTime nowdate = DateTime.Now;
                if (nowdate.Year - value.Year < 99 && value.Year > 18)
                {
                    dateBirthDay = value;
                }
                else
                {
                    throw new UserExeption("Invalid age.Age must be more 18 and less 99 age");
                }

            }
        }
        public int Age
        {
            get
            {
                DateTime dateNow = DateTime.Now;
                int age = dateNow.Year - dateBirthDay.Year;
                if (dateNow.Month < dateBirthDay.Month ||
                (dateNow.Month == dateBirthDay.Month && dateNow.Day < dateBirthDay.Day)) age--;
                return age;
            }
        }
        static private void ChekingName(string value, string name)
        {
            if (String.IsNullOrEmpty(value) || value.Length > 17 || Regex.IsMatch(value, "\\W"))
            {
                throw new UserExeption("Неверное имя");
            }
            else
            {

                name = value;
            }
        }

    }
}

