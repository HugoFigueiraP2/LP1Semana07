using System;

namespace GameUnits
{
    public class MilitaryUnit : Unit
    {
        public int AttackPower {get;}
        public int XP {get; private set;}

        public MilitaryUnit(int mov, int health, int AttackPower) : base(mov,health)
        {
            AttackPower = attackPower;
            XP = 0;

        }

        
    }

}