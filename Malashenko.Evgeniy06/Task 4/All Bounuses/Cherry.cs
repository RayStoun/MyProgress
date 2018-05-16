using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Cherry : Bonus
    {
        protected Cherry(double x, double y) : base(x, y)
        {
        }
        public new string NameBonus = "Cherry";
        public override void GetBonuses(Player player, Bonus bonuses)
        {
            if(player.EatHim(player, bonuses))
            {
                player.Speed =player.Speed* 1.5;
                //какое-то время
            }
        }

    }
}
