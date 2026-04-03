using System;

class Zoo
{
    public static void Main()
    {
        // Polymorphism
        Animal animal1 = new Dog();
        Animal animal2 = new Cat();
        Animal animal3 = new Bird();

        // instances
        animal1.MakeSound();
        animal2.MakeSound();
        animal3.MakeSound();
    }
}
