using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Aple : Bonus
    {
        protected Aple(double x, double y) : base(x, y)
        {
        }
        public new string NameBonus { get; set; }

        public override void GetBonuses(Player player, Bonus bonuses)
        {
            if(player.EatHim(player, bonuses))
            {
                player.HitPoints += 1;
            }
        }
    }
}
