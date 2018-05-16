using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersAndRewards.Shared;
using UsersAndRewards.BL.Logic;

namespace UsersAndRewardingPL_WinForms
{
    public partial class GeneralForm : Form
    {
        private ILogic logic;
        List<User> listUsers = new List<User>();
        List<Reward> listRewards = new List<Reward>();


        public GeneralForm(ILogic logic)
        {
            InitializeComponent();
            this.logic = logic;
            logic.GetUsers();
             UpdateUsersGrid();
             UpdateRewardsGrid();
        }
        Random newrandom = new Random();
        private void AddUser()
        {
            var userForm = new UserForm(logic.GetRewards());
            if (userForm.ShowDialog()==DialogResult.OK)
            {
                var name = userForm.FirstName;
                var last = userForm.LastName;
                var dt = userForm.BirthDate;
                var rewards = userForm.rewardToAdd;
                var user = new User();
                user.FirstName = name;
                user.LastName = last;
                user.BirthDate = dt.Date;
                user.Rewards = rewards;
                // initialization
                ctlDataGridViewUsers.AutoGenerateColumns = false;
                logic.AddUser(user);
                UpdateUsersGrid();
            }
        }
        private void AddReward()
        {
            var rewardForm = new RewardForm();
            if (rewardForm.ShowDialog() == DialogResult.OK)
            {
                var nameReward = rewardForm.Title;
                var description = rewardForm.Description;
                var reward = new Reward();
                reward.Title = nameReward;
                reward.Description = description;
                ctlDataGridViewRewards.AutoGenerateColumns = false;
                logic.AddReward(reward);
                UpdateRewardsGrid();
            }
        }
        //public void SetDataGridView(int Id, string firstName, string secoundName, int age)
        //{
        //    ctlDataGridViewUsers.Rows.Add(Id, firstName, secoundName, age);
        //}  
        private void btnExitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteUser(int userId)
        {           
            if (CheckedMessageYesOrNo() == DialogResult.Yes)
            {
                logic.DeleteUser(userId);
                UpdateUsersGrid();
            }
        }
        //private void RefreshUsersGrid()
        //{
        //    ctlUsersGrid.DataSource = null;
        //    ctlUsersGrid.DataSource = data.GetUsersList();
        //}
        private void RefreshUserGrid()
        {
            var user = logic.GetUsersViewModel();
            ctlDataGridViewUsers.DataSource = user;
            ctlDataGridViewUsers.Refresh();
        }
        private void RefreshRewardGrid()
        {
            // var reward= logic
        }
        private void DeleteRewards(int rewardId)
        {          
            if (CheckedMessageYesOrNo() == DialogResult.Yes)
            {
                logic.DeleteReward(rewardId);
                UpdateRewardsGrid();
                UpdateUsersGrid();
            }
        }
        private void UpdateUsersGrid()
        {
            ctlDataGridViewRewards.AutoGenerateColumns = false;
            var users = logic.GetUsersViewModel();
            ctlDataGridViewUsers.DataSource = users;
            ctlDataGridViewUsers.Refresh();
        }
        private void UpdateRewardsGrid()
        {
            var rewards = logic.GetRewards();
            ctlDataGridViewRewards.DataSource = null;
            ctlDataGridViewRewards.DataSource = rewards;
        }
        private DialogResult CheckedMessageYesOrNo()
        {
            var res = MessageBox.Show(
                "Are you sure?",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            return res;
        }
        private void EditUser(int userId)
        {
           var selectedUser = logic.GetUsers().FirstOrDefault(u => u.UserId == userId);
            var editUserForm = new EditUser(logic.GetRewards());
            if (editUserForm.ShowDialog() == DialogResult.OK)
            {
                var name = editUserForm.EditFirstName;
                var last = editUserForm.EditLastName;
                var dt = editUserForm.EditBirthdate;
                var rewards = editUserForm.editRewards;
                selectedUser.FirstName = name;
                selectedUser.LastName = last;
                selectedUser.BirthDate = dt.Date;
                selectedUser.Rewards = rewards;
                logic.UpdateUser(selectedUser);
                UpdateUsersGrid();
            }
        }
        private void EditReward(int rewardId)
        {
            var selectedReward = logic.GetRewards().FirstOrDefault(u => u.RewardId == rewardId);
            var editReward = new EditRewardForm();
            if (editReward.ShowDialog() == DialogResult.OK)
            {
                var title = editReward.Title;
                var description = editReward.Description;
                selectedReward.Title = title;
                selectedReward.Description = description;
                logic.UpdateReward(selectedReward);
                UpdateRewardsGrid();
            }
        }    
    }
}
