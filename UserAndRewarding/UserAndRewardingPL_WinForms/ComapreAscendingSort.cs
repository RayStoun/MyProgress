using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndRewards.Shared;

namespace UsersAndRewardingPL_WinForms
{
    class ComapreAscendingSort : IComparer<UserViewModel>
    {
        public int Compare(UserViewModel x, UserViewModel y)
        {
           return  x.FirstName.CompareTo(y.FirstName);
        }
    }
}
