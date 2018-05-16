using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    abstract class Enemy : Entiti
    {
        public double Speed { get; set; }
        protected Enemy(double x, double y, double speed, double hitpoints) : base(x, y)
        {
            Speed = speed;
            HitPointsEnemies = hitpoints;
        }
        public double HitPointsEnemies { get; set; }

       
    }
}
