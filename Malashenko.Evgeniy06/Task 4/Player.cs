using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Player : Entiti, IIMoving,IEatHim
    {
        public  new string  Name{ get; set; }
        public double  Speed { get; set; }
        public int HitPoints { get; set; }
        
        protected Player(double x, double y, double speed) : base(x, y)
        {
            Speed = speed;
        }
        

        public void Moving(Entiti entities)
        {
            bool start = IAmOnTheMap(entities);
            //  и какая -то логика в зависимости от действий игрока
        }

        public bool EatHim(Entiti player, Entiti bonus)
        {
           if(player.X==bonus.X && player.Y == player.Y)
           {
                return true;
           }
            else
            {
                return false;
            }
        }
    }
}
