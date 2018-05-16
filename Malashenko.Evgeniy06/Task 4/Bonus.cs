using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    abstract class Bonus : Entiti
    {
        protected Bonus(double x, double y) : base(x, y)
        {
        }
        public string NameBonus;

        abstract public void GetBonuses(Player player, Bonus bonuses);
       
    }
}
