using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersAndRewards.Shared;
using UsersAndRewards.BL.Logic;


namespace UsersAndRewardingPL_WinForms
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ILogic logic = new Logic();
            Application.Run(new GeneralForm(logic));
        }
    }
}
