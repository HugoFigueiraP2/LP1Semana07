using System;

namespace GameUnits
{
    public class SpyUnit : XPUnit
    {
        private int movement;
        
        public override float Cost{get;}

        public SpyUnit() : base(8,2) 
        {
            Cost = 12.5f;
            
        }

        public void GetSecretInfo(Unit unit)
        {
        
            if(unit.GetType() == typeof(SpyUnit))
            {
                XP +=3;
            }
            else if(unit.GetType() == typeof(MilitaryUnit))
            {
                XP += 2;
            }

            else
            {
                XP += 1;
            }
        }

        public override void Move()
        {
            
            Console.WriteLine(movement);
        }

    }

}