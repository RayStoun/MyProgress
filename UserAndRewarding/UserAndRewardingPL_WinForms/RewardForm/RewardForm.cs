using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsersAndRewardingPL_WinForms
{
    public partial class RewardForm : Form
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public RewardForm(GeneralForm form1)
        {
            InitializeComponent();
        }
        public RewardForm()
        {
            InitializeComponent();
        }


        private void btnOkReward_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                DialogResult = DialogResult.None;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNameReward_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameReward.Text)||txtNameReward.Text.Length>150)
            {
                ctlErrorRewardProvider.SetError(txtNameReward, "Name Cannot be emoty");
                e.Cancel = true;
            }
            else

            {
                ctlErrorRewardProvider.SetError(txtNameReward, string.Empty);
                e.Cancel = false;
            }
        }

        private void txtNameReward_Validated(object sender, EventArgs e)
        {
            Title = txtNameReward.Text;
        }

      

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                ctlErrorRewardProvider.SetError(txtDescription, "Name Cannot be empty");
                e.Cancel = true;
            }
            else

            {
                ctlErrorRewardProvider.SetError(txtDescription, string.Empty);
                e.Cancel = false;
            }
        }

        private void txtDescription_Validated(object sender, EventArgs e)
        {
            Description = txtDescription.Text;
        }
    }
}
