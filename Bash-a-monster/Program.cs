using System.Security.Cryptography;
int x = 1;
Trailblazer Trailblazer = new Trailblazer()
{
    Name = "Stelle",
    Hitpoints = 100,
};

Sunday SundayPeon = new Sunday()
{
    Name = "Sundays goon",
    Hitpoints = 50,
    AttackDmg = 1 * x,
};
Console.WriteLine($"\n{Trailblazer.Name} ska slåss mot {SundayPeon.Name} hjälp henne vinna");
Random random = new Random();
while (Trailblazer.Hitpoints >= 0 && SundayPeon.Hitpoints >= 0)
{
    Console.WriteLine("\nVad ska hon göra. A, slå med bat B, skydda med lance C, heala med hat");
    string Choice = Console.ReadLine().ToUpper();

    if (Choice == "A")
    {
        Trailblazer.AttackDmg = random.Next(5, 15);
        SundayPeon.AttackDmg = random.Next(1, 10);

        SundayPeon.Hitpoints -= Trailblazer.AttackDmg;
        Trailblazer.Hitpoints -= SundayPeon.AttackDmg;

        Console.WriteLine($"du slog och gjorde {Trailblazer.AttackDmg} dmg ({SundayPeon.Hitpoints})");
        Console.WriteLine($"du blev slagen och tog {SundayPeon.AttackDmg} dmg ({Trailblazer.Hitpoints})");

    }
    else if (Choice == "B")
    {
                SundayPeon.AttackDmg = random.Next(1, 10);

        Trailblazer.Hitpoints -= (SundayPeon.AttackDmg / 4) * 3;
        SundayPeon.Hitpoints -= SundayPeon.AttackDmg / 4;
        Console.WriteLine($"{SundayPeon.Name} skadade sig på din lance och tog {SundayPeon.AttackDmg / 4} dmg ({SundayPeon.Hitpoints})");
        Console.WriteLine($"du blev slagen och tog {(SundayPeon.AttackDmg / 4) * 3} dmg ({Trailblazer.Hitpoints})");

    }
    else if (Choice == "C")
    {
                SundayPeon.AttackDmg = random.Next(1, 10);

        Trailblazer.AttackDmg = random.Next(5, 15);
        Trailblazer.Hitpoints += Trailblazer.AttackDmg;
        Trailblazer.Hitpoints -= SundayPeon.AttackDmg;

        Console.WriteLine($"du använde hatten och healade {Trailblazer.AttackDmg} {Trailblazer.Hitpoints}");
        Console.WriteLine($"du blev slagen och tog {SundayPeon.AttackDmg} dmg ({Trailblazer.Hitpoints})");

    }

}
if (Trailblazer.Hitpoints >= 0){
Console.WriteLine("You win");
}
if (Trailblazer.Hitpoints <=0){a
a
Console.WriteLine("You lose");
}
