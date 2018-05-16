using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Home : Entiti
    {
        public Home(double x, double y) : base(x, y)
        {
        }
        public void HidePlayer(Player player,Home home)
        {
            if(player.X==home.X && player.Y == home.Y)
            {
                //Игрок спрятан
            }
        }
    }
}
