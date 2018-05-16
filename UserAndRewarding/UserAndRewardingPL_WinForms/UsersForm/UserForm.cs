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

namespace UsersAndRewardingPL_WinForms
{
    public partial class UserForm : Form
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        private List<Reward> rewards;
        public List<Reward> rewardToAdd = new List<Reward>();

        public UserForm(List<Reward> rewards)
        {
            this.rewards = rewards;
            InitializeComponent();
            AddRewardsInCheckBox();
            
        }
        private void btnOk_Click(object sender, EventArgs e)
        {

            if (!ValidateChildren())
            {
                DialogResult = DialogResult.None;
            }
        }
        private void AddRewardsInCheckBox()
        {
            if (rewards != null)
            {
                foreach (var item in rewards)
                {
                    checkedListRewards.Items.Add(item.Title, CheckState.Unchecked);
                }
            }
            
        }

        private void checkedListRewards_Validated(object sender, EventArgs e)
        {
            if (checkedListRewards.CheckedItems != null)
            {
                foreach (int item in checkedListRewards.CheckedIndices)
                {
                    rewardToAdd.Add(rewards[item]);
                }
            }
        }
    }
}
