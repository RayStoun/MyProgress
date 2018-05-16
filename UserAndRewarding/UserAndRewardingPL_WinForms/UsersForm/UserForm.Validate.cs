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
using System.Text.RegularExpressions;

namespace UsersAndRewardingPL_WinForms
{
    partial class UserForm:Form
    {
        private void ValidateDate(Control control, DateTime dt, string errorMessage, CancelEventArgs e)
        {
            if (dt == null || DateTime.Now.Year - 150 < dt.Year)
            {
                ctlErrorProvider.SetError(control, errorMessage);
            }
            else
            {
                ctlErrorProvider.SetError(txtBirthDate, string.Empty);
            }
        }
        private void Validate(Control ctl, string ctrValue, string errorMessage, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ctrValue))
            {
                ctlErrorProvider.SetError(ctl, errorMessage);
                e.Cancel = true;
            }
            else

            {
                ctlErrorProvider.SetError(ctl, string.Empty);
                e.Cancel = false;
            }
        }
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            Validate(txtFirstName, txtFirstName.Text.Trim(), "Name Cannot be emoty", e);
        }

        private void txtFirstName_Validated(object sender, EventArgs e)
        {
            FirstName = DeleteAllBesidesWords( txtFirstName.Text.Trim());
        }

        private void txtLastName_Validated(object sender, EventArgs e)
        {
            LastName = DeleteAllBesidesWords(txtLastName.Text.Trim());
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            Validate(txtLastName, txtLastName.Text.Trim(), "Last Name Cannot be emoty", e);
        }

        private void ctlBirthDate_Validating(object sender, CancelEventArgs e)
        {
            ValidateDate(txtBirthDate, txtBirthDate.Value, "Birth date cannot be empty and more 150 age", e);
        }

        private void ctlBirthDate_Validated(object sender, EventArgs e)
        {
            BirthDate = txtBirthDate.Value;
        }
        private string DeleteAllBesidesWords(string str)
        {
           return Regex.Replace(str, "\\W", "");
        }
    }
}
