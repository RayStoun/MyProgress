using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Bear : Enemy, IIMoving, IEatHim
    {
        public new double HitPointsEnemies { get; set; }
        protected Bear(double x, double y, double speed, double hitpoints) : base(x, y, speed,hitpoints)
        {
            Speed = speed;
            HitPointsEnemies = hitpoints;
        }
        public new double Speed;
        public new string Name = "Bear";
        
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
