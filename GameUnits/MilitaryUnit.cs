using System;

namespace GameUnits
{
    public sealed class MilitaryUnit : Unit // Heranca!!
    {

        private int movement; 

        public int AttackPower {get; }


        
        public int XP {get; private set; }


        
        public override int Health 
        { 
            get => base.Health;         
            set => base.Health = value + XP; 
        }


        
        public override float Cost 
        {
            get => AttackPower + XP;
        }

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {                         
            XP          = 0;                                           
            AttackPower = attackPower;


            movement    = mov;
        }


        
        public override void Move()
        {
            movement++;

            Console.WriteLine(movement);
            
        }
        public void Attack(Unit u)
        {  
            XP += 10;

            u.Health -= AttackPower;
        }
    }
}
