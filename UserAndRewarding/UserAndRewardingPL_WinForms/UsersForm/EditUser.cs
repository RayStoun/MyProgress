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
    public partial class EditUser : Form
    {
        public string EditFirstName;
        public string EditLastName;
        public DateTime EditBirthdate;
        private List<Reward> rewards;
        public List<Reward> editRewards = new List<Reward>();
        public EditUser(List<Reward> rewards)
        {
            this.rewards = rewards;
            InitializeComponent();
            AddRewardsInCheckBox();
        }
        private void AddRewardsInCheckBox()
        {
            if (rewards != null)
            {
                foreach (var item in rewards)
                {

                    checkedEditListRewards.Items.Add(item.Title);
                }
            }

        }
        private void checkedListRewards_Validated(object sender, EventArgs e)
        {
            if (checkedEditListRewards.CheckedItems != null)
            {
                foreach (int item in checkedEditListRewards.CheckedIndices)
                {
                    if (!editRewards.Contains(rewards[item]))
                    {
                        editRewards.Add(rewards[item]);
                    }
                   
                }
            }
        }
        //private bool CheckRewards(Reward reward)
        //{
        //    if (editRewards == null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        var selectedrewards = editRewards.Where(u => u.RewardId == reward.RewardId);
        //        return selectedrewards == null;
        //    }
        //}
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                DialogResult = DialogResult.None;
            }
        }
        private void txtEditFirstName_Validating(object sender, CancelEventArgs e)
        {
            Validate(txtEditFirstName, txtEditFirstName.Text.Trim(), "Name cannot be empy", e);
        }

        private void txtEditFirstName_Validated(object sender, EventArgs e)
        {
            EditFirstName = txtEditFirstName.Text.Trim();
        }

        private void txtEditLastName_Validating(object sender, CancelEventArgs e)
        {
            Validate(txtEditLastName, txtEditLastName.Text.Trim(), "Name Cannot be emoty", e);
        }

        private void txtEditLastName_Validated(object sender, EventArgs e)
        {
            EditLastName = txtEditLastName.Text.Trim();
        }

        private void txtEditBirthdate_Validating(object sender, CancelEventArgs e)
        {
            ValidatingDate(txtEditBirthdate, txtEditBirthdate.Value, "Name Cannot be emoty", e);
        }

        private void txtEditBirthdate_Validated(object sender, EventArgs e)
        {
            EditBirthdate = txtEditBirthdate.Value;
        }
        private void ValidatingDate(Control control, DateTime dt, string errorMessage, CancelEventArgs e)
        {
            if (dt == null || DateTime.Now.Year - 150 >= dt.Year)
            {
                errorProviderEditUser.SetError(control, errorMessage);
                e.Cancel = true;
            }
            else
            {
                errorProviderEditUser.SetError(txtEditBirthdate, string.Empty);
                e.Cancel = false;
            }
        }
        private void Validate(Control ctl, string ctrValue, string errorMessage, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ctrValue))
            {
                errorProviderEditUser.SetError(ctl, errorMessage);
                e.Cancel = true;
            }
            else

            {
                errorProviderEditUser.SetError(ctl, string.Empty);
                e.Cancel = false;
            }
        }
    }
}
