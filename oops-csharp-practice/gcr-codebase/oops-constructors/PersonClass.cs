using System;
class Person
{
    //variable
    public string name;
    public int age;

    // Parameterized constructor
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Copy constructor
    public Person(Person person)
    {
        name = person.name;
        age = person.age;
    }

    public void Display()
    {
        Console.WriteLine(name + "'s age is " + age);
    }
}

class PersonClass
{
    public static void Main()
    {
        Person person1 = new Person("Penny", 27);
        Person person2 = new Person(person1);

        person1.Display();
        person2.Display();
    }
}
