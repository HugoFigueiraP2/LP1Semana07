using System;

namespace GameUnits
{
    class Program
    {
        private static void Main(string[] args)
        {

            Unit mu = new MilitaryUnit(1, 10, 2);
            Unit su = new SettlerUnit();

            MilitaryUnit attackUnit = mu as MilitaryUnit;

            attackUnit.Attack(su); 

            attackUnit.Move();
            su.Move();

            Console.WriteLine($"Military Health: {attackUnit.Health}");
            Console.WriteLine($"Settler Health: {su.Health}");
            Console.WriteLine($"Military Cost: {attackUnit.Cost}");
            Console.WriteLine($"Settler Cost: {su.Cost}");
            attackUnit.Attack(su);
            Console.WriteLine($"Settler Health after: {su.Health}");


        }
    }
}
