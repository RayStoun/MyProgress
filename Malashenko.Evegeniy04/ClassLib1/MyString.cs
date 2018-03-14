using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class MyString
    {
        char[] str;
        
        public static MyString operator +(MyString str, MyString str2)
        {
            return new MyString(str.ToString() + str2.ToString());
        }
        public MyString(string str)
        {
            this.str = str.ToCharArray();
        }
        public static MyString operator -(MyString str, MyString str2)
        {
            return new MyString(str.ToString().Replace(str2.ToString(),String.Empty)); 
        }

        public static bool operator == (MyString str1, MyString str2)
        {
            return  str1.ToString() == str2.ToString();
        }
        public static bool operator!=(MyString str1, MyString str2)
        {
            return !(str1.ToString() == str2.ToString());
        }
    }
}
