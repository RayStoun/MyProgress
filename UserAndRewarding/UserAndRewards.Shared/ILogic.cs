using System.Collections.Generic;
namespace UsersAndRewards.Shared
{
    public interface ILogic:IDate
    {
        List<UserViewModel> GetUsersViewModel();
    }
}
    