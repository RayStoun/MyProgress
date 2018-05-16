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
    public partial class EditRewardForm : Form
    {
        public EditRewardForm()
        {
            InitializeComponent();
        }
        public string Title { get; set; }
        public string Description { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNameReward_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEditNameReward.Text) || txtEditNameReward.Text.Length > 150)
            {
                errorEditRewardProvider.SetError(txtEditNameReward, "Name Cannot be emoty");
                e.Cancel = true;
            }
            else

            {
                errorEditRewardProvider.SetError(txtEditNameReward, string.Empty);
                e.Cancel = false;
            }
        }

        private void txtNameReward_Validated(object sender, EventArgs e)
        {
            Title = txtEditNameReward.Text;
        }



        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEditDescription.Text))
            {
                errorEditRewardProvider.SetError(txtEditDescription, "Name Cannot be empty");
                e.Cancel = true;
            }
            else

            {
                errorEditRewardProvider.SetError(txtEditDescription, string.Empty);
                e.Cancel = false;
            }
        }

        private void txtDescription_Validated(object sender, EventArgs e)
        {
            Description = txtEditDescription.Text;
        }
    }
}
