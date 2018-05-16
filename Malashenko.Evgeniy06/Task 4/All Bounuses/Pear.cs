using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Pear : Bonus
    {
        protected Pear(double x, double y) : base(x, y)
        {
        }

        public override void GetBonuses(Player player, Bonus bonuses)
        {
            throw new NotImplementedException();
        }
        public  new string  NameBonus { get; set; }
    }
}
