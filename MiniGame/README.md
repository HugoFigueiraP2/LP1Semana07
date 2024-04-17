### Diagram _UML_
```mermaid
classDiagram
    class Program{
        Main()

    }

    class Player{
        +Player(string)

    }

    class Sword{
        +BladeLength() float
        +Sword(float) float
        +AttackWithSord() void

    }

    class Weapon{
        #power: float
        +Weapon(float) float

    }

    class Gun{
        +Ammo() int
        +Gun(float,int)
        FireRun() void

    }

    class Enemy{
        +Enemy(string)

    }

    class Character{
        #weapons: array
        +Name() string
        +Fight()

    }

    Character o-- Weapon
    Character ..> Gun
    Gun ..|> Weapon
    Character ..> Sword
    Sword ..|> Weapon
    Enemy ..> Weapon
    Enemy ..> Gun
    Enemy ..|> Character
    Program --> Character
    Player ..|> Character
    
    


    