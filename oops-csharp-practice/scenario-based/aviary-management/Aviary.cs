using System;
class Aviary
{
    public static void Main()
    {
        Bird[] birds =
        {
            new Eagle { Name = "Tian", Species = "Eagle" },
            new Sparrow { Name = "Lian", Species = "Sparrow" },
            new Duck { Name = "Sian", Species = "Duck" },
            new Penguin { Name = "Cian", Species = "Penguin" },
            new Seagull { Name = "Jian", Species = "Seagull" }
        };

        foreach (Bird bird in birds)
        {
            bird.DisplayInfo();

            // Check flying ability
            if (bird is IFlyable)
            {
                ((IFlyable)bird).Fly();
            }

            // Check swimming ability
            if (bird is ISwimmable)
            {
                ((ISwimmable)bird).Swim();
            }
        }
    }
}
