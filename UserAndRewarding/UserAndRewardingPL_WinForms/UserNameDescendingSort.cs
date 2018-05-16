using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndRewards.Shared;

namespace UsersAndRewardingPL_WinForms
{
    class UserNameDescendingSort : IComparer<UserViewModel>
    {
        int IComparer<UserViewModel>.Compare(UserViewModel x, UserViewModel y)
        {
            if (y.FirstName.CompareTo(x.FirstName) < 0)
                return -1;
            else if (y.FirstName.CompareTo(x.FirstName) > 0)
                return 1;
            else
                return 0;

        }
    }
}
