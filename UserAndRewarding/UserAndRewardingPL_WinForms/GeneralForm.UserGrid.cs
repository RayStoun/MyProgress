using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersAndRewards.Shared;
using UsersAndRewards.BL.Logic;

namespace UsersAndRewardingPL_WinForms
{
    partial class GeneralForm
    {
        private void btnAddUserToolStripMenu_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void btnMenuDeleteUser_Click(object sender, EventArgs e)
        {
          
            DeleteUser(GetIdUser());
        }
        private void btnDeleteUserToolStripMenu_Click(object sender, EventArgs e)
        {
            DeleteUser(GetIdUser());
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser();
        }
        private void btnMenuEditUser_Click(object sender, EventArgs e)
        {
            EditUser(GetIdUser());
        }

        private void btnMenuStripEditUser_Click(object sender, EventArgs e)
        {
            EditUser(GetIdUser());
        }
        private int GetIdUser()
        {
            var index = ctlDataGridViewUsers.SelectedCells[0].RowIndex;
            var id = (int)ctlDataGridViewUsers[clmId.Name, index].Value;
            return id;
        }
    }
}
