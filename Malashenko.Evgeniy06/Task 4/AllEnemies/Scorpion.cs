using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Scorpions : Enemy, IEatHim, IIMoving
    {
        public new double Speed { get; set; }
        public new  double HitPointsEnemies { get; set; }
        protected Scorpions(double x, double y, double speed, double hitpoints) : base(x, y, speed, hitpoints)
        {
            Speed = speed;
            HitPointsEnemies = hitpoints;
        }

        public bool EatHim(Entiti entities, Entiti entities2)
        {
            throw new NotImplementedException();
        }

        public void Moving(Entiti entities)
        {
            throw new NotImplementedException();
        }
    }
}
