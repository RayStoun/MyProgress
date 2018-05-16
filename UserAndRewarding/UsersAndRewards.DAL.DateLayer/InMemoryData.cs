using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndRewards.Shared;

namespace UsersAndRewards.DAL.DataLayer
{
    public class InMemoryData : IDate
    {
        private List<User> users;

        private List<Reward> rewards;

        public List<Reward> rewardToAdd;

        public InMemoryData()
        {
            users = new List<User>();
            rewards = new List<Reward>();
            HardCodeRewards();
           // HardCodeUsers();
        }
        public void AddReward(Reward reward)
        {
            var maxID = 0;
            var ids = rewards.Select(u => u.RewardId);
            if (ids.Count() != 0)
            {
                maxID = ids.Max();
            }
            reward.RewardId = maxID + 1;
            rewards.Add(reward);
        }

        public void AddUser(User user)
        {
            var maxId = 0;
            var ids = users.Select(u => u.UserId);
            if (ids.Count() != 0)
            {
                maxId = ids.Max();
            }

            user.UserId = maxId + 1;
            users.Add(user);
        }

        public void DeleteReward(int rewardId)
        {
            var selectedReward = rewards.FirstOrDefault(u => u.RewardId == rewardId);
            if (selectedReward != null)
            {
                rewards.Remove(selectedReward);
            }
        }
        

        public void DeleteUser(int userId)
        {           
            var selectedUser = users.FirstOrDefault(u => u.UserId == userId);
            if (selectedUser != null)
            {
                users.Remove(selectedUser);
            }
        }

        public Reward GetRewardById(int rewardId)
        {

            Reward finded = rewards.Find(item => item.RewardId == rewardId);
            return finded;
        }

        public List<Reward> GetRewards()
        {
            return rewards;
        }

        public User GetUserById(int userId)
        {
            User finded = users.Find(item => item.UserId == userId);
            return finded;

        }

        public List<User> GetUsers()
        {
            return users;
        }

        public void UpdateReward(Reward reward)
        {
            var findReward = rewards.Find(item => item.RewardId == reward.RewardId);
            findReward = reward;
        }

        public void UpdateUser(User user)
        {
            var findUser = users.Find(item => item.UserId == user.UserId);
            findUser = user;
        }
        private void HardCodeRewards()
        {
            var rew1 = new Reward();
            rew1.Title = "Настоящая запырка";
            rew1.Description = "за самое изящное пускание пузырей";
            AddReward(rew1);
            var rew2 = new Reward();
            rew2.Title = "Настоящий дубатор";
            rew2.Description = "За прямоту, ты всегда либо хороший, либо плохой";
            AddReward(rew2);
            var rew3 = new Reward();
            rew3.Title = "Самый здоровый шакал";
            rew3.Description = "Ваша мухопендрия в идеальном состоянии";
            AddReward(rew3);
            var rew4 = new Reward();
            rew4.Title = "Огромный бутряк";
            rew4.Description = "Вы напугали деревенского старосту";
            AddReward(rew4);
            var rew5 = new Reward();
            rew5.Title="Болельшик";
            rew5.Description = "Вы конечно же любите ыгу";
            AddReward(rew5);
            var rew6 = new Reward();
            rew6.Title = "Вася";
            rew6.Description = "Надо было отвечать на все вопросы";
            AddReward(rew6);
        }
        private void HardCodeUsers()
        {
            var user1 = new User();
            user1.FirstName = "Иосиф";
            user1.LastName = "Бродский";
            user1.BirthDate = new DateTime(1977, 12, 13);
            AddUser(user1);
            var user2 = new User();
            user2.FirstName = "Егор";
            user2.LastName = "Летов";
            user2.BirthDate = new DateTime(1964, 9, 10);
            AddUser(user2);

        }
    }
}
