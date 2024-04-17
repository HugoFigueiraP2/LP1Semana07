using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Unit unit1 = new Unit(100,50);
            Unit unit2 = new Unit(80, 30);
            unit1.Move();
            unit2.Move();
            
            
        }
    }
}
