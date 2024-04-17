using System;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        
        public SettlerUnit(int movement, int health)
        {
            movement = 1;
            health = 2;

            
            
        }
       
        Unit u = new SettlerUnit();
        SettlerUnit su = u as SettlerUnit();

        
    }

}