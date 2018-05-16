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
    public partial class GeneralForm
    {
        private void btnMenuAddReward_Click(object sender, EventArgs e)
        {
            AddReward();
        }
        private void btnMenuEditReward_Click(object sender, EventArgs e)
        {
            EditReward(GetRewardById());
        }
        private void btnMenuDeleteReward_Click(object sender, EventArgs e)
        {
            DeleteRewards(GetRewardById());
        }

        private void ctlAddRewards_Click(object sender, EventArgs e)
        {
            AddReward();
        }
        private void deleteRewardToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            DeleteRewards(GetRewardById());
        }
        private int GetRewardById()
        {
            var index = ctlDataGridViewRewards.SelectedCells[0].RowIndex;
            var id = (int)ctlDataGridViewRewards[clmRewardID.Name, index].Value;
            return id;
        }
        private void editRewardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditReward(GetRewardById());
        }
    }
}

